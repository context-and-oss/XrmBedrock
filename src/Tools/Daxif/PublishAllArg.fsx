#load "_Config.fsx"
open _Config
open DG.Daxif

Solution.PublishAll(selectedEnvironment ())
