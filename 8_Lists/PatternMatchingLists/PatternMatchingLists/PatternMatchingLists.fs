let sum list =
    let rec loop accum = function
        | [] -> accum
        | head :: tail -> loop (accum + head) tail
    loop 0 list

[<EntryPoint>]
let main argv =
    let argument = [ 1; 2; 3 ]
    printfn "The sum of elements is %i" (sum argument)
    0