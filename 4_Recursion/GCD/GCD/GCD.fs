// After a several of executions 'y' argument (the first one) becomes smaller than the impicit argument 'x'.
// The terminal condition is when 'y' equals 0.
let rec gcd y = function
    | x when y = 0 -> x
    | x when x >= y -> gcd (x % y) y
    | x -> gcd (y % x) x

[<EntryPoint>]
let main argv =
    printf "GCD of 259 and 111 is %i\n" (gcd 259 111)
    printf "GCD of 3 and 117 is %i" (gcd 3 118)
    0