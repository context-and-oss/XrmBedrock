import assert from 'node:assert/strict';
import { spawnSync } from 'node:child_process';
import { mkdtempSync, mkdirSync, writeFileSync, readFileSync, readdirSync, rmSync } from 'node:fs';
import os from 'node:os';
import path from 'node:path';
import vm from 'node:vm';
import { test } from 'node:test';

const config = new URL('../esbuild.config.mjs', import.meta.url).pathname;
const folder = 'templatepublisherprefix_templateprojectname';
function fixture(run) {
    const cwd = mkdtempSync(path.join(os.tmpdir(), 'webresources-'));
    const src = path.join(cwd, 'src', folder);
    const dist = path.join(cwd, 'dist', folder);
    mkdirSync(path.join(src, 'forms'), { recursive: true });
    const build = mode => spawnSync(process.execPath, [config, ...(mode ? [`--mode=${mode}`] : [])], { cwd, encoding: 'utf8' });
    try { run({ src, dist, build }); } finally { rmSync(cwd, { recursive: true, force: true }); }
}
function sources(src) {
    writeFileSync(path.join(src, 'shared.ts'), "export const value = 'account';");
    writeFileSync(path.join(src, 'forms/account.ts'), "import { value } from '../shared'; export function onLoad() { return value; }");
    writeFileSync(path.join(src, 'forms/contact.ts'), "export function onLoad() { return 'contact'; }");
    writeFileSync(path.join(src, 'ignored.d.ts'), 'declare const value: string;');
}
function execute(files) {
    const browser = vm.createContext({});
    files.forEach(file => vm.runInContext(readFileSync(file, 'utf8'), browser));
    return browser.WebResources;
}
test('single bundle exposes all form handlers', () => fixture(({ src, dist, build }) => {
    sources(src);
    const result = build();
    assert.equal(result.status, 0, result.stderr);
    assert.deepEqual(readdirSync(dist).sort(), ['WebResources.js', 'WebResources.js.map']);
    const resources = execute([path.join(dist, 'WebResources.js')]);
    assert.equal(resources.forms.account.onLoad(), 'account');
    assert.equal(resources.forms.contact.onLoad(), 'contact');
}));
test('individual bundles preserve paths and work alone or together', () => fixture(({ src, dist, build }) => {
    sources(src);
    const result = build('individual');
    assert.equal(result.status, 0, result.stderr);
    const account = path.join(dist, 'forms/account.js');
    const contact = path.join(dist, 'forms/contact.js');
    assert.equal(execute([account]).forms.account.onLoad(), 'account');
    const resources = execute([account, contact]);
    assert.equal(resources.forms.account.onLoad(), 'account');
    assert.equal(resources.forms.contact.onLoad(), 'contact');
    assert.equal(readdirSync(dist).includes('ignored.js'), false);
}));
test('switching modes removes stale outputs', () => fixture(({ src, dist, build }) => {
    sources(src);
    assert.equal(build('individual').status, 0);
    assert.equal(build('single').status, 0);
    assert.deepEqual(readdirSync(dist).sort(), ['WebResources.js', 'WebResources.js.map']);
    rmSync(path.join(src, 'forms/contact.ts'));
    assert.equal(build('individual').status, 0);
    assert.equal(readdirSync(path.join(dist, 'forms')).includes('contact.js'), false);
}));
test('declarations-only projects build in either mode', () => fixture(({ src, dist, build }) => {
    writeFileSync(path.join(src, 'empty.d.ts'), 'declare const value: string;');
    for (const mode of ['single', 'individual']) {
        assert.equal(build(mode).status, 0);
        assert.deepEqual(readdirSync(dist), []);
    }
}));
test('invalid modes leave existing outputs intact', () => fixture(({ dist, build }) => {
    mkdirSync(dist, { recursive: true });
    writeFileSync(path.join(dist, 'keep.js'), 'keep');
    assert.notEqual(build('typo').status, 0);
    assert.equal(readFileSync(path.join(dist, 'keep.js'), 'utf8'), 'keep');
}));
test('conflicting file and folder namespaces fail', () => fixture(({ src, build }) => {
    writeFileSync(path.join(src, 'forms.ts'), 'export const value = 1;');
    writeFileSync(path.join(src, 'forms/account.ts'), 'export const value = 2;');
    const result = build();
    assert.notEqual(result.status, 0);
    assert.match(result.stderr, /Conflicting webresource namespaces/);
}));
