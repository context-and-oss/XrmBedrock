// Lint rules for src/. `npm run dev` and `npm run build` run these for you — see build.mjs.
//
//   npm run lint        report every problem
//   npm run lint:fix    fix the ones that can be fixed automatically
//
// The rules are deliberately strict: this project is small and self-contained, so the
// guardrails below (file size, complexity, unsafe DOM writes) are cheap to satisfy and
// catch the mistakes that turn a web resource into a blank form.

import js from "@eslint/js";
import html from "@html-eslint/eslint-plugin";
import checkFile from "eslint-plugin-check-file";
import importPlugin from "eslint-plugin-import-x";
import noUnsanitized from "eslint-plugin-no-unsanitized";
import promise from "eslint-plugin-promise";
import security from "eslint-plugin-security";
import sonarjs from "eslint-plugin-sonarjs";
import unicorn from "eslint-plugin-unicorn";
import globals from "globals";
import tseslint from "typescript-eslint";

// Shared DataverseHtml plugins and rules for webresource source files.
export const sharedPlugins = {
  // Registered as `import` so the rules read `import/order` and friends, even though the
  // package is the maintained `-x` fork. Its `settings` keys stay `import-x/*`.
  import: importPlugin,
  promise,
  unicorn,
  sonarjs,
  security,
  "no-unsanitized": noUnsanitized,
  "check-file": checkFile,
};

export const sharedRules = {
  // ── Imports ──
  "import/no-duplicates": "error",
  "import/no-cycle": "error",
  "import/order": [
    "error",
    {
      groups: ["builtin", "external", "internal", ["parent", "sibling", "index"], "type"],
      "newlines-between": "always",
      alphabetize: { order: "asc", caseInsensitive: true },
    },
  ],

  // ── Async / Promises (no-floating-promises is on via the type-checked base) ──
  "promise/no-return-wrap": "error",
  "promise/always-return": ["error", { ignoreLastCallback: true }],
  "promise/catch-or-return": "error",
  "promise/no-promise-in-callback": "error",

  // ── TypeScript extras (beyond recommendedTypeChecked) ──
  "@typescript-eslint/consistent-type-imports": [
    "error",
    { prefer: "type-imports", fixStyle: "inline-type-imports" },
  ],
  "@typescript-eslint/prefer-nullish-coalescing": ["error", { ignorePrimitives: { string: true } }],
  "@typescript-eslint/prefer-optional-chain": "error",
  "@typescript-eslint/no-unnecessary-type-assertion": "error",
  "@typescript-eslint/no-unused-vars": [
    "error",
    { argsIgnorePattern: "^_", varsIgnorePattern: "^_" },
  ],

  // ── Unicorn (curated; prevent-abbreviations off — domain uses Qr/sdk/api/ref) ──
  "unicorn/no-nested-ternary": "error",
  "unicorn/no-lonely-if": "error",
  "unicorn/prefer-string-slice": "error",
  "unicorn/no-useless-undefined": "error",
  "unicorn/prefer-array-flat-map": "error",
  "unicorn/prevent-abbreviations": "off",

  // ── SonarJS (bug patterns & complexity) ──
  "sonarjs/cognitive-complexity": ["error", 15],
  "sonarjs/no-identical-functions": "error",
  "sonarjs/no-collapsible-if": "error",
  "sonarjs/prefer-immediate-return": "error",
  "sonarjs/no-duplicate-string": ["error", { threshold: 5 }],

  // ── Security (detect-object-injection off — too noisy on bracket access) ──
  "security/detect-eval-with-expression": "error",
  "security/detect-non-literal-regexp": "error",
  "security/detect-object-injection": "off",
  "no-unsanitized/method": "error",
  "no-unsanitized/property": "error",

  // ── Size & complexity (guardrails against growth) ──
  "max-lines": ["error", { max: 250, skipBlankLines: true, skipComments: true }],
  "max-lines-per-function": ["error", { max: 80, skipBlankLines: true, skipComments: true }],
  "max-params": ["error", { max: 4 }],
  complexity: ["error", { max: 10 }],

  // ── General code quality ──
  eqeqeq: ["error", "always", { null: "ignore" }],
  "no-console": ["error", { allow: ["warn", "error"] }],
  "no-debugger": "error",
  "prefer-const": "error",
  "no-var": "error",
  "spaced-comment": ["error", "always", { markers: ["/"] }],
};

// Relaxations for tests: assertions on untyped fixtures, and long files, are fine there.
export const testFileRules = {
  "@typescript-eslint/no-unsafe-assignment": "off",
  "@typescript-eslint/no-unsafe-member-access": "off",
  "@typescript-eslint/no-unsafe-call": "off",
  "max-lines": "off",
  "max-lines-per-function": "off",
  "sonarjs/no-duplicate-string": "off",
};

export default tseslint.config(
  {
    // The .mjs files are the project's plumbing, not your code — they are plain JavaScript
    // and outside tsconfig.json, so they are not linted.
    ignores: [
      "dist",
      "node_modules",
      "typings",
      ".config",
      "eslint.config.js",
      "build.mjs",
      "html.build.mjs",
      "esbuild.config.mjs",
      "tests/**",
    ],
  },
  { files: ["src/**/*.ts", "src/**/*.html"] },
  js.configs.recommended,
  ...tseslint.configs.recommendedTypeChecked,
  {
    files: ["src/**/*.html"],
    ...tseslint.configs.disableTypeChecked,
    ...html.configs["flat/recommended"],
    rules: {
      ...tseslint.configs.disableTypeChecked.rules,
      "@html-eslint/no-aria-hidden-body": "error",
      "@html-eslint/no-aria-hidden-on-focusable": "error",
      "@html-eslint/no-empty-headings": "error",
      "@html-eslint/no-heading-inside-button": "error",
      "@html-eslint/no-positive-tabindex": "error",
      "@html-eslint/no-skip-heading-levels": "error",
      "@html-eslint/require-doctype": "error",
      "@html-eslint/require-img-alt": "error",
      "@html-eslint/require-lang": "error",
      "@html-eslint/require-title": "error",
      "@html-eslint/require-button-type": "error",
      "@html-eslint/require-details-summary": "error",
      "@html-eslint/require-frame-title": "error",
      "@html-eslint/require-input-label": "error",
      "@html-eslint/require-meta-viewport": "error",
    },
  },
  {
    files: ["src/**/*.ts"],
    languageOptions: {
      parserOptions: {
        project: ["./tsconfig.json"],
        tsconfigRootDir: import.meta.dirname,
      },
      globals: {
        ...globals.browser,
      },
    },
    settings: {
      "import-x/resolver": {
        typescript: { project: "./tsconfig.json" },
        node: true,
      },
    },
    plugins: sharedPlugins,
    rules: {
      ...sharedRules,

      // ── File & folder naming ──
      "check-file/filename-naming-convention": [
        "error",
        { "src/html/**/*.ts": "CAMEL_CASE" },
        { ignoreMiddleExtensions: true },
      ],
      "check-file/folder-naming-convention": ["error", { "src/html/**/": "KEBAB_CASE" }],
    },
  },
  {
    files: ["**/*.test.ts"],
    rules: testFileRules,
  },
);
