// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.


[<Struct>] type V3 = { a: int; b: int; c: int; } 


[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    printfn "System.IntPtr.Size = %i" System.IntPtr.Size

    let v1 = { a=1; b=2; c=3 }
    let v2 = { a=4; b=5; c=6 }
    let v3 = { a=1; b=2; c=3 }
    let vs = [ v1; v2; v3 ]
    printfn "vs = %A\n" vs

    // mono 64-bit: returns a list of three items, including the duplicate
    printfn "distinct vs = %A" (List.distinct vs)

    // mono 64-bit: returns 3 
    printfn "length of distinct vs = %i" (List.distinct vs |> List.length)

    System.Console.WriteLine();
    System.Console.WriteLine("Press any key...");

    System.Console.ReadKey(true) |> ignore

    0 // return an integer exit code
