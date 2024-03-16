open System.Diagnostics

(* A demo that shows how to replace a parameterized function by parameterless function in place,
   thanks to anonymous functions. *)

// The f parameter is a parameterless function.
let measure f =
    let timer = new Stopwatch()
    timer.Start()
    let returnValue = f ()
    printfn "Execution time is %i ms." timer.ElapsedMilliseconds
    returnValue

// fib is a function that has an int parameter.
let fib n =
    let rec loop previousFib accumulator counter =
        if counter = n then
            accumulator
        else
            loop accumulator (accumulator + previousFib) (counter + 1)
    loop 1I 0I 0

[<EntryPoint>]
let main argv =
    measure (fun () -> fib 5) |> ignore
    measure (fun () -> fib 100) |> ignore
    0