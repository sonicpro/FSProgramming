let incr =
  let counter = ref 0
  fun () ->
    counter.Value <- counter.Value + 1
    counter.Value

let main () =
  printfn "Counting by 3."
  printfn "%i" (incr ())
  printfn "%i" (incr ())
  printfn "%i" (incr ())

main ()
