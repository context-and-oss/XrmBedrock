import { spawn } from "node:child_process";

const children = new Set();

function run(command, args, options = {}) {
  const child = spawn(command, args, {
    stdio: "inherit",
    shell: process.platform === "win32",
    ...options,
  });
  children.add(child);
  child.on("close", (code) => {
    children.delete(child);
    if (code && code !== 0) process.exitCode = code;
  });
  return child;
}

function runOnce(command, args) {
  return new Promise((resolve, reject) => {
    const child = run(command, args);
    child.on("error", reject);
    child.on("close", (code) => (code === 0 ? resolve() : reject(new Error(`${command} exited ${code}`))));
  });
}

await runOnce("npm", ["run", "build"]);
await runOnce("dotnet", ["tool", "restore"], { cwd: "../../.." });

run("npm", ["run", "watch"]);
run("dotnet", ["xrmsync", "--profile", "webresources", "--watch"], { cwd: "../../.." });

for (const signal of ["SIGINT", "SIGTERM"]) {
  process.on(signal, () => {
    for (const child of children) child.kill(signal);
  });
}
