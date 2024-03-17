// The only difference from pattern matching tuples is that we cannot deconstruct records in pattern matcing expression.
// Instead we are referring to a record particular fields in "when" guards.

type coords = { X: float; Y: float }

let getQuadrantName = function
    | { X = 0.0; Y = 0.0 } -> "Undefined"
    | x when x.X >= 0.0 && x.Y >= 0.0 -> "I"
    | x when x.X <= 0.0 && x.Y >= 0.0 -> "II"
    | x when x.X <= 0.0 && x.Y <= 0.0 -> "III"
    | x when x.X >= 0.0 && x.Y <= 0.0 -> "IV"

let executeAndPrintResult f x message =
    printfn "%A %s %s" x message (f x)

[<EntryPoint>]
let main argv =
    let message = "is in quadrant"
    executeAndPrintResult getQuadrantName { X = 1.0; Y = 1.0 } message
    executeAndPrintResult getQuadrantName { X = -1.0; Y = 1.0 } message
    executeAndPrintResult getQuadrantName { X = -1.0; Y = -1.0 } message
    executeAndPrintResult getQuadrantName { X = 1.0; Y = -1.0 } message
    0