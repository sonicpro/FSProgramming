let promptForANumber message =
    printf message
    try
        int(System.Console.ReadLine())
    with
        // The patterns are of "Type Test Pattern" pattern type.
        | :? System.FormatException -> System.Int32.MinValue
        | :? System.OverflowException -> System.Int32.MinValue


[<EntryPoint>]
let main argv =
    let x = promptForANumber "x = "
    let y = promptForANumber "y = "

    printfn "%i + %i = %i" x y (x + y)
    0