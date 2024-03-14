let rec nonTailRecursiveCount n =
  if n = 1000000 then
    printfn "done"
  else
    if n % 1000 = 0 then
      printfn "n: %i" n

    nonTailRecursiveCount (n + 1)
    () (* This function is not tail recursice because it
          performs extra work (by returning unit) after
          the recursive call is involved. *)

// nonTailRecursiveCount 0 // Only managed to pass 125000 recursions.

let rec tailRecursiveCount n =
  if n = 1000000 then
    printfn "done"
  else
    if n % 1000 = 0 then
      printfn "n: %i" n

    tailRecursiveCount (n + 1)

tailRecursiveCount 0


// This function is not TailRecursive.
let rec nonTailRecursiveMultiply x y =
  if y > 1 then
    x + nonTailRecursiveMultiply x (y - 1)
  else
    x

// nonTailRecursiveMultiply 1 1000000;


// We can make the function recursive through the closure to embed addition operatioon into the tail recursive function call.
let tailRecursiveMultiply x y =
  let rec loop accumulator counter =
    if counter > 1 then
      loop (accumulator + x) (counter - 1)
    else
      accumulator

  loop x y

tailRecursiveMultiply 1 1000000
