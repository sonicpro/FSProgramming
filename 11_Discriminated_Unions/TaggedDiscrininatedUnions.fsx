type switchstate =
  | On
  | Off
  | Adjustable of float

let toggle = function
  | On -> Off
  | Off -> On
  | Adjustable(increment) -> // Basically the cases if a union are constructors
  let pivot = 0.5
  if increment <= pivot then
    Adjustable(increment + pivot)
  else
    Adjustable(increment - pivot)

let main () =
  let x = On
  let y = Off
  let z = Adjustable 0.25 // Sensible values for increment are from 0 to 0.5.
  printfn "x: %A" x
  printfn "y: %A" y
  printfn "z: %A" z
  printfn "toggle y: %A" (toggle y)
  printfn "toggle z: %A" (toggle z)

main()
