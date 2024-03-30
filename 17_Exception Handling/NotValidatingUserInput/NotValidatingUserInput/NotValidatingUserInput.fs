let promptForANumber msg =
    printf msg
    int32(System.Console.ReadLine())

[<EntryPoint>]
let Main argv =
    let x = promptForANumber("x = ")
    let y = promptForANumber("y = ")
    printf "%i + %i = %i" x y (x + y)
    0
