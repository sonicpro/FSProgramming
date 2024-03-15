let f x = x * x
let g x = -x / 2.0 + 5.0

// Composition of f and g:
let fog = f << g


printfn "fog 0: %f" (fog 0.0) // (0.0 + 5.0)*(0.0 + 5.0)
printfn "fog 1: %f" (fog 1.0) // 4.5 * 4.5
