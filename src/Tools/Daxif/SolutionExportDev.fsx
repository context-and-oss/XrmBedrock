#load "_Config.fsx"
open _Config
open System.IO
open DG.Daxif

// Keep the original revision increment and export the extended payload with the zip.
let env = selectedEnvironment ()
let folder = solutionFolder ()
Directory.CreateDirectory(folder) |> ignore
Solution.UpdateVersionNumber(env, SolutionInfo.name, VersionIncrement.Revision)
Solution.Export(env, SolutionInfo.name, folder, managed = managed (), extended = true)
