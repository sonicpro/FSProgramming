let a = Set.ofList [ 1..10 ]
let b = Set.ofList [ 5..15 ]

// You can evaluate the following in emacs by selecting it and pressing C-c C-r.
Set.difference a b
// Set.dirrerence is the same as "-" operator.
a - b

Set.iter (fun x -> printf "%i " x) (Set.intersect a b)

Set.iter (fun x -> printf "%i " x) (Set.union a b)
// Set.union is the same as "+" operator.
Set.iter (fun x -> printf "%i " x) (a + b)
