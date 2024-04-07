// Define a list that prints every element to the screen at the point of initialisation.
// You can evaluate the following in emacs by selecting and pressing C-c C-r.
let intList =
  [ for a in 1 .. 10 do
    printfn "intList: %i" a
    yield a ]

// Define a sequence that prints nothing on the screen at the point of initialization.
let intSeq =
  seq { for a in 1 .. 10 do
        printfn "intSeq: %i" a
        yield a }

// However the sequence prints when we are iterating, for example requesting the fourth element:
Seq.item 3 intSeq
