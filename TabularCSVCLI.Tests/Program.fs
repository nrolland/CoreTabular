﻿
open NUnit.Framework
open MicrosoftResearch.Infer.Tabular.CLI

let runTest modelFileName =
        let modelFileName = System.IO.Path.GetFullPath(modelFileName)
        let exeDir = System.IO.Path.GetDirectoryName(modelFileName)
        System.Environment.CurrentDirectory <- exeDir
        runCLI "." None modelFileName "." false None None (Reuse "verified") true true true true

[<Test>]
let TrueSkill() =    
    runTest (System.IO.Path.Combine("..","..","..","Samples","TrueSkill","TrueSkill.csv"))
    Assert.True(true)


[<Test>]
let FaithfulCsv() =    
    runTest (System.IO.Path.Combine("..","..","..","Samples","Faithful","Model.csv"))
    Assert.True(true)

[<Test>]
let FaithfulTxt() = 
    runTest (System.IO.Path.Combine("..","..","..","Samples","Faithful","Model.txt"))  
    Assert.True(true)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
