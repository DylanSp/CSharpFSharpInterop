// Learn more about F# at http://fsharp.org

open CSharpLibrary
open System

[<EntryPoint>]
let main argv =
    let x = 4
    let y = 5
    printfn "%d + %d = %d" x y (Addition.Add(x, y))
    let _ = Console.ReadLine()
    0 // return an integer exit code
