# Remaining DAXIF support

This folder exists only for the extended-solution workflow. The `Tools.csproj`
project restores `Delegate.Daxif` and stages its runtime dependency closure in
`Daxif/runtime` when built. Do not check in restored binaries.

The only scripts are configuration, extended export, pre-import + solution import,
post-import, and publishing. No legacy generators, plugin/webresource sync, managed identity,
data manipulation, sample scripts or bundled executables are retained.

DAXIF 5.6.0 runs on .NET Framework 4.6.2. Execute these scripts with Visual Studio's
**.NET Framework F# Interactive** on Windows, not `dotnet fsi`. Pipelines use
`$(FsiPath)`. Build the solution (or `dotnet build src/Tools/Tools.csproj`) first.

```powershell
& $fsi src/Tools/Daxif/SolutionExportDev.fsx /env:Dev /dir:artifacts/solutions
& $fsi src/Tools/Daxif/SolutionImportArg.fsx /env:Test /dir:artifacts/solutions
& $fsi src/Tools/Daxif/PublishAllArg.fsx /env:Test
# Apply the extended post-import state after publishing.
& $fsi src/Tools/Daxif/SolutionPostImportArg.fsx /env:Test /dir:artifacts/solutions
```

Pass `managed` to export, import and post-import if using a managed solution.
The default remains unmanaged, as in the original extended-solution pipeline.
`DataverseUrl` overrides the selected environment URL. For noninteractive legacy
DAXIF authentication set `DAXIF_CLIENT_ID` and `DAXIF_CLIENT_SECRET`; the pipeline
maps these from the existing environment variable group's `DataverseAppId` and
**secret** `DataverseSecret`. `_Config.fsx` passes them to DAXIF using its original
`ClientSecret`, `mfaappid` and `mfaclientsecret` arguments, without putting the secret
on the process command line or in source control.

**Temporary gap:** DAXIF 5.6.0 cannot reuse the federated Azure CLI session. Its
extended-solution and publishing steps still need the library variable-group secret.
This does not require a secret-backed Azure service connection: keep Azure Resource
Manager connections federated, and let the modern dotnet tools use `azcli` as before.
No Power Platform service connection is needed for solution publishing/deployment.
Both the Azure-connected principal and legacy DAXIF principal need the appropriate
Dataverse application-user permissions. Remove this separate secret requirement once
the extended-solution workflow can use the modern connection tools.
