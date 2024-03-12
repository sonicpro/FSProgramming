// Generic function declaration.
let giveMeAThree x = 3

let throwAwayFirstInput x y = y

(* You need to evaluate the following expressions "interactively" to see results.
   In fsmode you need to press C-c C-r while the expression is selected. *)

throwAwayFirstInput 5 "value"

throwAwayFirstInput "thrownAway" 10.0

throwAwayFirstInput 5 30

// This function type is int -> int -> int;
let add x y = x + y

let z = add 10 (throwAwayFirstInput "this is a string" 5)

// The following won't compile, because given a pair of string, throwAwayFirstInput returns a string instead of int.
let f = add 10 (throwAwayFirstInput "this is a string" "so is this")
