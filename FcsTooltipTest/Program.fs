open FSharp.Management

type This = RelativePath<".">

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0