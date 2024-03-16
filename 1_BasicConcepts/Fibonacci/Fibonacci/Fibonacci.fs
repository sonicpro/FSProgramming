(* The following implementation is not tail-recursive, so it does not tolerate big Fibonacci numbers calculation. *)

//let rec fib = function
//  | 0 -> 0I
//  | 1 -> 1I
//  | n when n > 1 -> fib (n - 1) + fib (n - 2)
//  | _ -> failwith "Cannot evaluate fibonacci of a negative number."

let fib n =
    let rec loop previousFib accumulator counter =
        if counter = n then
            accumulator
        else
            loop accumulator (accumulator + previousFib) (counter + 1)
    loop 1I 0I 0

[<EntryPoint>]
let main argv =
  printf "fib 100: %A" (fib 100)
  //printf "fib -10: %A" (fib -10)
  0
