// DAXIF is retained only for extended-solution export, pre/post-import processing and publishing.
#r "runtime/Microsoft.Xrm.Sdk.dll"
#r "runtime/Microsoft.Crm.Sdk.Proxy.dll"
#r "runtime/Microsoft.IdentityModel.Clients.ActiveDirectory.dll"
#r "runtime/Microsoft.Xrm.Tooling.Connector.dll"
#r "runtime/Delegate.Daxif.dll"

open System
open System.IO
open DG.Daxif
open DG.Daxif.Common.Utility

let environmentValue name = System.Environment.GetEnvironmentVariable(name)
let connectionArgs =
    match environmentValue "DAXIF_CLIENT_ID", environmentValue "DAXIF_CLIENT_SECRET" with
    | null, null -> fsi.CommandLineArgs
    | clientId, secret when not (String.IsNullOrWhiteSpace clientId || String.IsNullOrWhiteSpace secret) ->
        Array.append fsi.CommandLineArgs [| "/method:ClientSecret"; "/mfaappid:" + clientId; "/mfaclientsecret:" + secret |]
    | _ -> failwith "Set both DAXIF_CLIENT_ID and DAXIF_CLIENT_SECRET for DAXIF authentication."

module Env =
    let create name defaultUrl =
        let url =
            match environmentValue "DataverseUrl" with
            | null | "" -> defaultUrl
            | overrideUrl -> overrideUrl
        Environment.Create(
            name = name,
            url = url,
            method = ConnectionType.ConnectionString,
            connectionString = sprintf "AuthType=OAuth; url=%s; LoginPrompt=Always; AppId=51f81489-12ee-4a9e-aaae-a2591f45987d; RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97" url,
            args = connectionArgs)

    let dev = create "Dev" "https://dev.crm4.dynamics.com"
    let test = create "Test" "https://test.crm4.dynamics.com"
    let uat = create "UAT" "https://uat.crm4.dynamics.com"
    let prod = create "Prod" "https://prod.crm4.dynamics.com"

module SolutionInfo =
    let name = "templatesolutionname"

module Path =
    let solutionFolder = System.IO.Path.Combine(__SOURCE_DIRECTORY__, "solutions")

let args = fsi.CommandLineArgs |> parseArgs
let selectedEnvironment () =
    let name = args |> tryFindArg ["env"; "e"] |> Option.defaultValue "Dev"
    Environment.Get name
let solutionFolder () =
    let folder = args |> tryFindArg ["dir"; "d"] |> Option.defaultValue Path.solutionFolder
    System.IO.Path.GetFullPath folder
let managed () = args |> tryFindArg ["managed"] |> Option.isSome
let solutionZipPath () =
    let suffix = if managed () then "_managed" else ""
    System.IO.Path.Combine(solutionFolder (), sprintf "%s%s.zip" SolutionInfo.name suffix)
