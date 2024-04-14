// This function is bad! See "Encapsulating_Mutable_State.fsx" for the example of a good function.
let withSideEffects (cell: string ref) =
  cell.Value <- "I am completely different!"

let main () =
  let cell = ref "Hello"

  printfn "Mutable data: %s" cell.Value

  cell.Value <- "World"
  printfn "Mutable data: %s" cell.Value

  printfn "Passing a mutable data to a bad function."
  withSideEffects cell

  printfn "Mutable data %s" cell.Value

main ()
