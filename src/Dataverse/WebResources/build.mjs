// One project/build/deployment folder for form scripts and self-contained HTML pages.
import { globSync } from "glob";
import { spawn } from "node:child_process";
import { fileURLToPath } from "node:url";

import { buildOnce, startWatch } from "./html.build.mjs";

const root = fileURLToPath(new URL("./", import.meta.url));
const args = process.argv.slice(2);
const watch = args.includes("--watch");
const modes = args.filter((arg) => arg.startsWith("--mode="));
if (modes.length > 1 || modes.some((arg) => !["--mode=single", "--mode=individual"].includes(arg)) ||
    args.some((arg) => arg !== "--watch" && !arg.startsWith("--mode="))) {
  throw new Error("Usage: npm run build -- [--mode=single|individual] [--watch]");
}
function run(command, parameters) {
  return new Promise((resolve, reject) => {
    const child = spawn(command, parameters, { cwd: root, stdio: "inherit" });
    child.on("error", reject);
    child.on("close", (code) => code === 0 ? resolve() : reject(new Error(`${command} exited ${code}`)));
  });
}
try {
  await run(process.execPath, ["node_modules/typescript/bin/tsc", "--noEmit"]);
  // Validate before the script bundler cleans dist, keeping a failed lint from deleting output.
  await run(process.execPath, ["node_modules/eslint/bin/eslint.js", "src"]);
  await run(process.execPath, ["esbuild.config.mjs", ...modes]);
  await buildOnce({ lint: "skip" });
  if (watch) {
    const stopHtml = await startWatch();
    const scriptSources = globSync("src/templatepublisherprefix_templateprojectname/**/*.ts", {
      cwd: root, ignore: "**/*.d.ts",
    });
    const scripts = scriptSources.length > 0 ? spawn(process.execPath, ["esbuild.config.mjs", ...modes, "--watch"], {
      cwd: root, stdio: "inherit",
    }) : undefined;
    for (const signal of ["SIGINT", "SIGTERM"]) {
      process.on(signal, () => { scripts?.kill(); void stopHtml(); });
    }
    scripts?.on("close", (code) => { void stopHtml(); process.exitCode = code ?? 1; });
  }
} catch (error) {
  console.error(`[build] ${error.message}`);
  process.exitCode = 1;
}
