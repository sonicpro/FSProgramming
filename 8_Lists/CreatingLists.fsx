let numbers = [ 1; 2; 3; 5; 8; 12; 14; 84 ]

// You can evaluate the following in emacs by selecting it and press C-c C-r.
numbers


// Consing a list.
let newNumbers = 12 :: numbers

newNumbers

// Using List.init method.
let generatedList = List.init 3 (fun i -> i * 2)

generatedList

// List comprehension.
// Ranges:
let chars = [ 'A' .. 'a' ]

chars

// Generators:
let tuples = [
for a in 1 .. 2 do
for b in 1 ..5 do
  yield (a, b) ]

tuples

// yield! operator accepts a list and flattens it to the generated list.
let quarts = [
for a in 1 .. 4 do
yield! [ a .. a + 3] ]

quarts

