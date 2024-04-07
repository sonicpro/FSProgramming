// The value that evaluates to the infinite sequence
// of integers starting from 0 with the step of 2.
// Notice that the local recursive function "loop" does not have
// a termination condition.
let everyPossibleEvensInTheWorld =
    let rec loop x = seq { yield x; yield! loop (x + 2) }
    loop 0

// We must use one of the functions from Seq module, like "take", to
// make the program finite.
[<EntryPoint>]
let Main argv =
    for a in (Seq.take 5 everyPossibleEvensInTheWorld) do
        printfn "%i" a
    0;;
