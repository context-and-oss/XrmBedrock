// Builds every web resource in src/html/ into its own self-contained HTML file in dist/,
// and lints src/ on the way.
//
// Each folder under src/html/ is one web resource. A folder holding an index.html is built into
// dist/<prefix>_<project>/html/<folder>.html, which XrmSync uploads as <prefix>_<solution>/html/<folder>.html.
// Add a folder, get another web resource — there is nothing to configure.
//
// Dataverse serves an HTML web resource as a single file, so everything — the
// JavaScript, the CSS and any images you import — has to end up inside it.
// esbuild bundles the TypeScript and the CSS, and we paste both into the HTML shell.
//
//   node html.build.mjs            build once (minified); a lint error fails the build
//   node html.build.mjs --watch    rebuild on every save (readable output); lint problems are
//                             reported but never stop dist/ from being rewritten
//
// The rules live in eslint.config.js.
//
import { build, context } from "esbuild";
import { ESLint } from "eslint";
import { readFile, writeFile, mkdir, readdir, rm } from "node:fs/promises";
import { dirname, join } from "node:path";
import { fileURLToPath } from "node:url";

const root = dirname(fileURLToPath(import.meta.url));
const srcDir = join(root, "src", "html");

/** The three files every web resource folder is made of. */
const ENTRY_HTML = "index.html";
const ENTRY_TS = "main.ts";
const ENTRY_CSS = "styles.css";

// Anything imported from src/ that is not code gets baked in as a data: URI,
// because a web resource cannot load files from anywhere else.
const assetLoaders = {
  ".png": "dataurl",
  ".jpg": "dataurl",
  ".jpeg": "dataurl",
  ".gif": "dataurl",
  ".svg": "dataurl",
  ".webp": "dataurl",
  ".woff": "dataurl",
  ".woff2": "dataurl",
};

/**
 * Every web resource in src/html/: one per folder that has an index.html in it. Loose files
 * directly under src/ (assets.d.ts, anything shared) are not web resources and are skipped.
 *
 * @returns {Promise<{name: string, dir: string}[]>} sorted by name, so output is stable.
 */
export async function listResources() {
  const entries = await readdir(srcDir, { withFileTypes: true }).catch((error) => {
    if (error.code === "ENOENT") return [];
    throw error;
  });
  const found = [];

  for (const entry of entries) {
    if (!entry.isDirectory()) continue;
    const dir = join(srcDir, entry.name);
    const shell = await readFile(join(dir, ENTRY_HTML), "utf8").catch(() => undefined);
    if (shell !== undefined) found.push({ name: entry.name, dir });
  }

  return found.sort((a, b) => a.name.localeCompare(b.name));
}

const outDir = "dist/templatepublisherprefix_templateprojectname/html";

const jsOptions = (resource, minify) => ({
  entryPoints: [join(resource.dir, ENTRY_TS)],
  bundle: true,
  minify,
  format: "iife",
  target: "es2020",
  write: false,
  // The CSS is bundled separately below; drop the import from the JavaScript.
  loader: { ...assetLoaders, ".css": "empty" },
  logLevel: "silent",
});

const cssOptions = (resource, minify) => ({
  entryPoints: [join(resource.dir, ENTRY_CSS)],
  bundle: true,
  minify,
  write: false,
  loader: assetLoaders,
  logLevel: "silent",
});

/** `</script>` inside the bundle would end the tag early and break the page. */
const escapeForScript = (js) => js.replace(/<\/(script)/gi, "<\\/$1");
const escapeForStyle = (css) => css.replace(/<\/(style)/gi, "<\\/$1");

const textOf = (result) => result.outputFiles[0]?.text ?? "";

// One instance for the whole process: it keeps the TypeScript program warm, so the first
// lint of a watch session costs a second or two and every one after it is near-instant.
let eslintInstance;
const linter = () => (eslintInstance ??= new ESLint({ cwd: root, errorOnUnmatchedPattern: false }));

/** Lints src/ and prints anything it finds. Returns the error count; warnings do not count. */
async function lintSrc() {
  const eslint = linter();
  const results = await eslint.lintFiles(["src"]);

  const formatter = await eslint.loadFormatter("stylish");
  const output = (await formatter.format(results)).trim();
  if (output) process.stderr.write(`${output}\n`);

  return results.reduce((total, result) => total + result.errorCount, 0);
}

/**
 * Builds every HTML web resource in src/html/.
 *
 * @param {object} [options]
 * @param {boolean} [options.minify]
 * @param {"fail" | "report" | "skip"} [options.lint] `"fail"` throws on a lint error; `"report"` only prints.
 * @returns {Promise<{outPath: string, bytes: number}[]>} one entry per web resource.
 */
export async function buildOnce({ minify = true, lint = "fail" } = {}) {
  // One lint pass over all of src/, whatever it holds — not one per web resource.
  const errorCount = lint === "skip" ? 0 : await lintSrc();
  if (lint === "fail" && errorCount > 0) {
    throw new Error(
      `${errorCount} lint ${errorCount === 1 ? "error" : "errors"} in src/ — see above. ` +
        `Run \`npm run lint:fix\` to fix what can be fixed automatically.`,
    );
  }

  const resources = await listResources();
  await rm(join(root, outDir), { recursive: true, force: true });
  await mkdir(join(root, outDir), { recursive: true });
  return Promise.all(resources.map((resource) => buildResource(resource, minify)));
}

async function buildResource(resource, minify) {
  const [js, css] = await Promise.all([
    build(jsOptions(resource, minify)),
    build(cssOptions(resource, minify)),
  ]);
  return writeHtml(resource, textOf(js), textOf(css));
}

async function writeHtml(resource, js, css) {
  const shell = await readFile(join(resource.dir, ENTRY_HTML), "utf8");

  for (const marker of ["<!--STYLE-->", "<!--SCRIPT-->"]) {
    if (shell.split(marker).length !== 2) {
      throw new Error(`${resource.name}/index.html must contain exactly one ${marker}.`);
    }
  }
  assertSelfContained(shell, resource);

  const html = shell
    .replace("<!--STYLE-->", `<style>\n${escapeForStyle(css).trim()}\n</style>`)
    .replace("<!--SCRIPT-->", `<script>\n${escapeForScript(js).trim()}\n</script>`);

  const outPath = join(root, outDir, `${resource.name}.html`);
  await mkdir(dirname(outPath), { recursive: true });
  await writeFile(outPath, html);
  return { outPath, bytes: Buffer.byteLength(html) };
}

/** A web resource that reaches out to another file or a CDN is broken inside Dataverse. */
function assertSelfContained(html, resource) {
  // Accept all HTML attribute quoting styles; single quotes and unquoted URLs
  // must not bypass the self-contained resource check.
  const tags = html.match(/<(?:script|link|img)\b[^>]*>/gi) ?? [];
  for (const tag of tags) {
    const attribute = (name) => {
      const match = tag.match(new RegExp(`\\s${name}\\s*=\\s*(?:"([^"]*)"|'([^']*)'|([^\\s>]+))`, "i"));
      return match ? (match[1] ?? match[2] ?? match[3]) : undefined;
    };
    const src = attribute("src");
    if ((src !== undefined && !src.startsWith("data:")) ||
        /<link\b/i.test(tag) && attribute("rel")?.toLowerCase() === "stylesheet" ||
        attribute("srcset") !== undefined) {
      throw new Error(`${resource.name} references something outside itself: ${tag}\n` +
        "Import assets from main.ts or styles.css so they get embedded.");
    }
  }
}

/** Watches TypeScript, CSS and the HTML shells; returns a function to stop watching. */
export async function startWatch() {
  const resources = await listResources();

  // Two watchers per web resource — one for the TypeScript, one for the CSS — rewriting that
  // resource's HTML whenever either side finishes. The latest output of each is kept here,
  // keyed by resource name so the resources never overwrite each other's halves.
  const latest = new Map(resources.map((r) => [r.name, { js: undefined, css: undefined }]));

  async function writeIfReady(resource) {
    const state = latest.get(resource.name);
    if (state.js === undefined || state.css === undefined) return;
    try {
      const { outPath, bytes } = await writeHtml(resource, state.js, state.css);
      log(`built ${relative(outPath)} (${kb(bytes)})`);
    } catch (error) {
      log(`build failed: ${error.message}`);
      return;
    }

    // Lint after writing, never before: a lint error must not stop dist/ from being
    // refreshed, or XrmSync would keep syncing a stale file while you fix the problem.
    try {
      const errorCount = await lintSrc();
      if (errorCount > 0) {
        log(`${errorCount} lint ${errorCount === 1 ? "error" : "errors"} — see above`);
      }
    } catch (error) {
      log(`lint failed: ${error.message}`);
    }
  }

  const collect = (resource, key) => ({
    name: `collect-${resource.name}-${key}`,
    setup(pluginBuild) {
      pluginBuild.onLoad({ filter: /(?:main\.ts|styles\.css)$/ }, async (args) => ({
        contents: await readFile(args.path, "utf8"),
        loader: args.path.endsWith(".ts") ? "ts" : "css",
        watchFiles: [join(resource.dir, ENTRY_HTML)],
      }));
      pluginBuild.onEnd(async (result) => {
        if (result.errors.length === 0) {
          latest.get(resource.name)[key] = textOf(result);
          await writeIfReady(resource);
        } // otherwise esbuild has already printed the error

      });
    },
  });

  const contexts = await Promise.all(
    resources.flatMap((resource) => [
      context({
        ...jsOptions(resource, false),
        plugins: [collect(resource, "js")],
        logLevel: "error",
      }),
      context({
        ...cssOptions(resource, false),
        plugins: [collect(resource, "css")],
        logLevel: "error",
      }),
    ]),
  );

  await Promise.all(contexts.map((ctx) => ctx.watch()));
  return () => Promise.all(contexts.map((ctx) => ctx.dispose()));
}

const relative = (p) => p.slice(root.length + 1);
const kb = (bytes) => `${(bytes / 1024).toFixed(1)} kB`;
const log = (message) => console.log(`[build] ${message}`);

// Only run when invoked directly, so build.mjs can import the functions above.
if (process.argv[1] && fileURLToPath(import.meta.url) === process.argv[1]) {
  const watch = process.argv.includes("--watch");
  try {
    if (watch) {
      await startWatch();
      log("watching for changes — press Ctrl+C to stop");
      // The watchers are set up per web resource when this starts, so a brand new folder
      // is not picked up until then.
      log("added a new web resource folder? stop and start this again to pick it up");
    } else {
      for (const { outPath, bytes } of await buildOnce()) {
        log(`built ${relative(outPath)} (${kb(bytes)})`);
      }
    }
  } catch (error) {
    console.error(`[build] ${error.message}`);
    process.exit(1);
  }

}
