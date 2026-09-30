#load "_Config.fsx"
open _Config
open DG.Daxif

// Run after publishing, using the exact same managed/unmanaged archive as PreImport.
ExtendedSolution.PostImport(selectedEnvironment (), solutionZipPath ())
