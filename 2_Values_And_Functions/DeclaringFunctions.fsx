// Example of not supported function declaration.
// Does not compile because not conform to the strongly-typed
// return type.
(*
let sign num =
  if num < 0 then "negative"
  elif num > 0 then "positive"
  else 0
*)

// An exapmle of void (unit) funcion.
let greeting () = printfn "Hello world"

greeting ()

// An example of nested function.
let sumOfDivisors n =
  let max = n / 2 // The largest divisor of a number cannot be greater than number / 2.
  let rec loop current max accumulator =
    if current > max then
      accumulator
    else
      if n % current = 0 then
        loop (current + 1) max (accumulator + current)
      else
        loop (current + 1) max accumulator
  loop 1 max 0

printfn "%d" (sumOfDivisors 9)
(* prints 4, because the sum of 9's divisors is 1 + 3. *)
