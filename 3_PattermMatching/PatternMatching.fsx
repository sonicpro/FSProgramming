// The additional parameter comes before the implicit parameter.
// So the type of getPrice is taxRate: float -> _arg1: string -> float.
let getPrice taxRate = function
  | "banana" -> 0.79 * (1.0 + taxRate)
  | "watermelon" -> 3.49 * (1.0 + taxRate)
  | "tofu" -> 1.09 * (1.0 + taxRate)
  | _ -> nan

getPrice 0.2 "watermelon"
// Returns var it: float = 4.188 (3.49 * (1.0 + 0.2)).

// An example of a function that matches a value to a pattern rather to a value.
// Binding a value to "n" identifier below is known as "variable binding".
let rec factorial = function
  | 0 | 1 -> 1
  | n -> n * factorial (n - 1)

factorial 3


// Guards are represented by filters added using "when" keyword.
// Notice the space between Minus operator and the number.
let sign = function
  | 0 -> 0
  | n when n < 0 -> -1
  | n when n > 0 -> 1
  | _ -> int nan

sign -100

// Another (better) option to beat the FS0025 warning of incomplete pattern is
// to throw early if the value does not match any of the patterns.
let sign' = function
  | 0 -> 0
  | n when n < 0 -> -1
  | n when n > 0 -> 1
  | _ -> failwith "The program was not expected to fall into the line 5 of \"sign'\"."

sign' 12
