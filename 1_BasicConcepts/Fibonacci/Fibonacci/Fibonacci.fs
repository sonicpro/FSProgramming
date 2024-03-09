let rec fib = function
  | 0 -> 0
  | 1 -> 1
  | n -> fib (n - 1) + fib (n - 2)
  // TODO: add thowing when n < 0.
  // | _ -> invalidArg "A parameter cannot be negative."

[<EntryPoint>]
let main argv =
  printf "fib 10: %i" (fib 10)
  0
