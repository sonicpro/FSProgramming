type switchstate =
  | On
  | Off

let x = On
let y = Off

let main () =
  printfn "x: %A" x
  printfn "y: %A" y

main()
