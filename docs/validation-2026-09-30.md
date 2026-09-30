# Dotnet-tool migration validation — 2026-09-30

Target: `https://abs-preview.crm.dynamics.com/`, solution `magnus`, publisher `ctx`.

## Tools

- XrmContext 4.0.0-beta.26
- XrmDefinitelyTyped 7.0.0-preview.10
- XrmMockup.MetadataGenerator 1.2.0
- XrmPluginCore 1.4.1 (Abstractions 1.1.0)
- XrmSync 1.0.0-preview.27, locally packed from this workspace

XrmSync preview.25 was the newest available NuGet package, but contains
DataverseConnection 1.2.4. It prompted for another device code. The current
XrmSync source already references 1.2.5. Its unprefixed preview.27 tag was not
matched by the release workflow. The workflow now accepts both tag conventions,
and the changelog is updated so the release script produces preview.27.
The locally packed preview.27 reused the initial XrmContext sign-in without
another login. This was historical validation of the local build, not the published release.

## Completed checks

- Packed and installed XrmBedrock; created a separate generated project.
- Generated C# context (including custom API proxies after deployment), TypeScript
  form/Web API declarations, and XrmMockup metadata from magnus.
- Generated project Release build: zero warnings, zero errors.
- Repository offline-fixture Release build: zero warnings/errors; 2 tests passed.
- Final template package inspected: no Tools, offline fixtures, generated metadata,
  build output or node_modules included.
- Generated project tests: 2 passed (account plugin and typed echo Custom API).
- JavaScript bundle built with npm XrmQuery; npm audit: zero vulnerabilities.
- XrmSync analyzed two plugins, two steps and one Custom API.
- Additive dry run and live sync succeeded. Four unrelated webresources were preserved.
- Invoked `ctx_BedrockEcho` remotely and verified exact input/output equality.
- Created an account through the deployed Create plugin pipeline and deleted it.
- Compared deployed `ctx_magnus/Bedrock.js` to the local bundle byte-for-byte and
  published that resource. Removed the superseded test-only resource path.
- Repeat dry run: zero creates/updates/deletes for owned components.
- XrmSync unit tests excluding `Category=AssemblyAnalyzer`: 396 passed.
  The full run had 9 failures because its four sample assemblies were not built;
  the other 396 tests passed. No sample-test assertions were disabled or changed.

## Remaining release/operational checks

- Publish XrmSync preview.27 to NuGet (not performed from this workspace).
- Azure DevOps service-connection, export/import and managed-identity pipeline
  execution was not tested against deployment environments.
- Browser form-handler execution was not tested; bundle compilation, content
  upload and publication were verified.
- XrmSync warns that the merged assembly's collectible load context cannot be
  unloaded. Registration analysis and sync succeed; watch-session memory behavior
  remains an upstream follow-up.
- Deployed XrmContext emits nullable diagnostics in generated helper/API code;
  the template scopes CS8602/CS8603/CS8625 suppression to generated context files.

The validation assembly, plugin steps, `ctx_BedrockEcho` and
`ctx_magnus/Bedrock.js` remain in magnus for inspection. Temporary accounts were deleted.
Local test projects and detailed logs are under `/tmp/xrmbedrock-validation/`.

## Template cleanup

Validation-only echo API, account trace plugin, webresource handler and smoke tests
were removed from the distributed template after live validation. The pre-existing
SampleArea data producer was removed too. The external validation projects under
`/tmp/xrmbedrock-validation/` retain the test code. Empty webresource builds create
the configured sync directory and clear stale bundles without shipping demo scripts.
The live validation results above describe the temporary test project, not application
code included in newly generated templates.

## Extended-solution exception

DAXIF remains only for extended export and pre/post-import processing. The minimal
Tools dependency host restores the legacy runtime from NuGet at build time; its
four scripts and runtime are staged with the full solution export folder for
deployment. F# configuration and all script bodies were type-checked without
executing remote operations. The Windows/.NET Framework extended export/import
pipeline has not been executed against a live deployment environment.

## Publishing and authentication gap

Publishing now uses `Solution.PublishAll` through the retained DAXIF runtime.
Solution build/deployment has no Power Platform SPN tasks or parameters. Modern
tools keep federated Azure Resource Manager connections; DAXIF continues to use
the existing Library `DataverseAppId` and secret `DataverseSecret`. This temporary
separate credential requirement is explicit and does not constrain the Azure
connection to client-secret authentication. Pipeline execution remains untested.

## Published-release migration

The template remains pinned to XrmSync 1.0.0-preview.27. The local XrmSync package
was removed from the workspace feed and its source mapping/cache entry was removed,
so restore now resolves XrmSync from NuGet.org instead of substituting the local build.
The GitHub v1.0.0-preview.27 release attaches XrmSync.1.0.0-preview.26.nupkg; both
versions currently return 404 from NuGet's package endpoint. Published preview.27
restore cannot yet be validated. The README records this packaging mismatch.

### Published package verified

NuGet now serves XrmSync 1.0.0-preview.27. Its package metadata identifies that
version and its runtime dependency is DataverseConnection 1.2.5. The exact published
package was downloaded from NuGet's flat-container endpoint and restored through a
temporary staging feed because NuGet's registration endpoint still lagged behind
the available package. The installed tool reports
`1.0.0-preview.27+d92706b9a3fe89dd2fe9a2b0d9ff9f139a380a17`. No local build was used,
and no permanent local XrmSync source override was added. The README availability
warning has been removed.
