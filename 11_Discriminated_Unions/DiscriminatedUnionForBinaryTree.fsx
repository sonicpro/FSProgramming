// The picture of the simpleTree below is on https:\/\/en.wikibooks.org\/wiki\/F_Sharp_Programming\/Discriminated_Unions.

type tree =
  | Leaf of int
  | Node of tree * tree // * between item types denotes the type of tuple.

let simpleTree =
  Node(
    Leaf 1,
    Node(
      Leaf 2,
      Node(
        Node(
          Leaf 4,
          Leaf 5
        ),
        Leaf 3
      )
    )
  )

let main () =
  printfn "%A" simpleTree

main()
