let rec fib = function
  | 0 -> 0
  | 1 -> 1
  | n when n > 1 -> fib (n - 1) + fib (n - 2)
  | _ -> failwith "Cannot evaluate fibonacci of a negative number."

[<EntryPoint>]
let main argv =
  printf "fib 4: %i" (fib 4)
  printf "fib -10: %i" (fib -10)
  0
