import * as esbuild from "esbuild";
import { globSync } from "glob";
import { mkdirSync, rmSync } from "node:fs";

const watchMode = process.argv.includes("watch");
const entryPoints = globSync("src/templatepublisherprefix_templateprojectname/**/*.ts");

// Never leave removed sources deployable through an old bundle.
rmSync("dist", { recursive: true, force: true });
mkdirSync("dist/templatepublisherprefix_templateprojectname", { recursive: true });

// A new project intentionally has no application webresources.
if (entryPoints.length === 0) {
    console.info("No webresources to bundle yet.");
    process.exit(0);
}

const options = {
    entryPoints,
    bundle: true,
    outbase: "src",
    outdir: "dist",
    format: "iife",
    sourcemap: true,
    logLevel: "info"
};
if (watchMode) {
    const context = await esbuild.context(options);
    await context.watch();
} else {
    await esbuild.build(options);
}
