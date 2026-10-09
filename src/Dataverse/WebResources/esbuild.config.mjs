import * as esbuild from "esbuild";
import { globSync } from "glob";
import { mkdirSync, readFileSync, rmSync } from "node:fs";
import path from "node:path";

const args = process.argv.slice(2);
const watchMode = args.includes("watch") || args.includes("--watch");
const packageJson = JSON.parse(readFileSync(new URL("./package.json", import.meta.url), "utf8"));
const modeArgs = args.filter(arg => arg.startsWith("--mode="));
const mode = modeArgs[0]?.slice("--mode=".length) ?? packageJson.config.bundleMode;
if (modeArgs.length > 1 || !["single", "individual"].includes(mode) ||
    args.some(arg => arg !== "watch" && arg !== "--watch" && !arg.startsWith("--mode="))) {
    throw new Error("Usage: node esbuild.config.mjs [--mode=single|individual] [--watch]");
}

const sourceDir = "src/templatepublisherprefix_templateprojectname";
const outputDir = "dist/templatepublisherprefix_templateprojectname";
const entryPoints = globSync(`${sourceDir}/**/*.ts`, { ignore: "**/*.d.ts" }).sort();

// Exported handlers have the same WebResources.<folder>.<file> API in either mode.
const entries = entryPoints.map(file => ({
    file,
    keys: path.relative(sourceDir, file).replace(/\\/g, "/").replace(/\.ts$/, "").split("/")
}));
// A file and folder with the same name cannot both occupy a handler namespace.
for (let i = 0; i < entries.length; i++) {
    for (let j = i + 1; j < entries.length; j++) {
        const a = entries[i].keys;
        const b = entries[j].keys;
        if (a.every((key, index) => key === b[index]) || b.every((key, index) => key === a[index])) {
            throw new Error(`Conflicting webresource namespaces: ${entries[i].file} and ${entries[j].file}`);
        }
    }
}

// Never leave removed sources or the other mode's bundles deployable.
if (!watchMode) rmSync("dist", { recursive: true, force: true });
mkdirSync(outputDir, { recursive: true });

if (entries.length === 0) {
    console.info("No webresources to bundle yet.");
    process.exit(0);
}

const common = {
    bundle: true,
    format: "iife",
    sourcemap: true,
    logLevel: "info"
};
const builds = mode === "single" ? [{
    ...common,
    // A virtual entry avoids generated sources and retains every module's exports.
    stdin: {
        contents: entries.map(({ file, keys }, index) =>
            `import * as resource${index} from ${JSON.stringify(`./${file.replace(/\\/g, "/")}`)};`
        ).join("\n") + "\n" + (() => {
            const tree = Object.create(null);
            entries.forEach(({ keys }, index) => {
                let node = tree;
                keys.slice(0, -1).forEach(key => node = node[key] ??= Object.create(null));
                node[keys.at(-1)] = `resource${index}`;
            });
            const render = node => typeof node === "string" ? node :
                `{${Object.entries(node).map(([key, value]) => `[${JSON.stringify(key)}]:${render(value)}`).join(",")}}`;
            return `module.exports = ${render(tree)};`;
        })(),
        resolveDir: process.cwd(),
        sourcefile: "webresources-entry.js"
    },
    globalName: "WebResources",
    outfile: `${outputDir}/WebResources.js`
}] : entries.map(({ file, keys }) => ({
    ...common,
    entryPoints: [file],
    globalName: `WebResources${keys.map(key => `[${JSON.stringify(key)}]`).join("")}`,
    outfile: `${outputDir}/${keys.join("/")}.js`
}));

if (watchMode) {
    const contexts = await Promise.all(builds.map(options => esbuild.context(options)));
    await Promise.all(contexts.map(context => context.watch()));
} else {
    await Promise.all(builds.map(options => esbuild.build(options)));
}
