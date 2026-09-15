import * as esbuild from "esbuild";
import { watch as watchFiles } from "node:fs";
import { mkdir, readFile, readdir, rm, writeFile } from "node:fs/promises";
import { dirname, extname, join, relative, sep } from "node:path";
import { fileURLToPath } from "node:url";

const root = dirname(fileURLToPath(import.meta.url));
const sourceRoot = join(root, "src");
const htmlRoot = join(sourceRoot, "html");
const formsRoot = join(sourceRoot, "forms");
const outputRoot = join(root, "dist");
const watch = process.argv.includes("--watch");

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

const toPosix = (value) => value.split(sep).join("/");
const withoutExtension = (value) => value.slice(0, -extname(value).length);
const identifier = (value) =>
  value
    .split(/[^A-Za-z0-9_$]+/)
    .filter(Boolean)
    .map((part) => `${part[0]?.toUpperCase() ?? ""}${part.slice(1)}`)
    .join("") || "Script";

async function walk(directory, predicate) {
  const found = [];
  for (const entry of await readdir(directory, { withFileTypes: true }).catch(() => [])) {
    const path = join(directory, entry.name);
    if (entry.isDirectory()) found.push(...(await walk(path, predicate)));
    else if (predicate(path)) found.push(path);
  }
  return found.sort();
}

async function htmlResources() {
  const shells = await walk(htmlRoot, (path) => path.endsWith(`${sep}index.html`));
  return shells.map((shell) => {
    const directory = dirname(shell);
    return {
      name: toPosix(relative(htmlRoot, directory)),
      directory,
      shell,
      script: join(directory, "main.ts"),
      style: join(directory, "styles.css"),
    };
  });
}

async function formScripts() {
  return (await walk(formsRoot, (path) => extname(path) === ".ts" && !path.endsWith(".d.ts"))).map(
    (entry) => ({
      entry,
      name: toPosix(withoutExtension(relative(formsRoot, entry))),
    }),
  );
}

const text = (result) => result.outputFiles[0]?.text ?? "";
const escapeScript = (value) => value.replace(/<\/(script)/gi, "<\\/$1");
const escapeStyle = (value) => value.replace(/<\/(style)/gi, "<\\/$1");

function assertSelfContained(html, resourceName) {
  const externalReferences = [
    /<script[^>]+\bsrc\s*=\s*["'](?!data:)/i,
    /<link[^>]+\brel\s*=\s*["']stylesheet["']/i,
    /<img[^>]+\bsrc\s*=\s*["'](?!data:)/i,
  ];

  for (const pattern of externalReferences) {
    const match = html.match(pattern);
    if (match) {
      throw new Error(
        `${resourceName} contains an external reference (${match[0]}). ` +
          "Import scripts, styles, images, and fonts from TypeScript/CSS so they are embedded.",
      );
    }
  }
}

async function buildHtml(resource, minify) {
  const [javascript, css, shell] = await Promise.all([
    esbuild.build({
      entryPoints: [resource.script],
      bundle: true,
      minify,
      format: "iife",
      target: "es2020",
      write: false,
      loader: { ...assetLoaders, ".css": "empty" },
    }),
    esbuild.build({
      entryPoints: [resource.style],
      bundle: true,
      minify,
      write: false,
      loader: assetLoaders,
    }),
    readFile(resource.shell, "utf8"),
  ]);

  const html = shell
    .replace("<!--STYLE-->", `<style>\n${escapeStyle(text(css)).trim()}\n</style>`)
    .replace("<!--SCRIPT-->", `<script>\n${escapeScript(text(javascript)).trim()}\n</script>`);
  assertSelfContained(html, resource.name);

  const output = join(outputRoot, `${resource.name}.html`);
  await mkdir(dirname(output), { recursive: true });
  await writeFile(output, html);
  console.log(`built ${toPosix(relative(root, output))}`);
}

async function buildFormScript(script, minify) {
  const output = join(outputRoot, "forms", `${script.name}.js`);
  await mkdir(dirname(output), { recursive: true });
  await esbuild.build({
    entryPoints: [script.entry],
    outfile: output,
    bundle: true,
    minify,
    sourcemap: true,
    format: "iife",
    target: "es2020",
    globalName: `templatecompanyname.templateprojectname.FormScripts.${identifier(script.name)}`,
  });
  console.log(`built ${toPosix(relative(root, output))}`);
}

async function discover() {
  const [html, forms] = await Promise.all([htmlResources(), formScripts()]);
  if (html.length === 0 && forms.length === 0) {
    throw new Error("No web resources found under src/html or src/forms.");
  }
  return { html, forms };
}

async function buildAll({ clean = true, minify = true } = {}) {
  if (clean) await rm(outputRoot, { recursive: true, force: true });
  const resources = await discover();
  await Promise.all([
    ...resources.html.map((resource) => buildHtml(resource, minify)),
    ...resources.forms.map((script) => buildFormScript(script, minify)),
  ]);
}

if (!watch) {
  await buildAll();
} else {
  await buildAll({ minify: false });
  let timer;
  let building = false;
  let pending = false;

  const rebuild = async () => {
    if (building) {
      pending = true;
      return;
    }
    building = true;
    try {
      await buildAll({ minify: false });
    } catch (error) {
      console.error(error);
    } finally {
      building = false;
      if (pending) {
        pending = false;
        await rebuild();
      }
    }
  };

  watchFiles(sourceRoot, { recursive: true }, () => {
    clearTimeout(timer);
    timer = setTimeout(() => void rebuild(), 150);
  });
  console.log("watching src/html and src/forms");
  await new Promise(() => {});
}
