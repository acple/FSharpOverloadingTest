open CSharpLib

[<EntryPoint>]
let main _ =
    let x, y = "abc", 123
    printfn "x: %s, y: %s" (x.A()) (y.A())
    0
