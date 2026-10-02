#load "_Config.fsx"
open _Config
open DG.Daxif

let env = selectedEnvironment ()
let zip = solutionZipPath ()
ExtendedSolution.PreImport(env, zip)
Solution.Import(env, zip, activatePluginSteps = true, extended = false, publishAfterImport = false)
