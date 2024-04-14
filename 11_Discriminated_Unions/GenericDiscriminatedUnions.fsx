open System

type tree<'a> =
  | Leaf of 'a
  | Node of tree<'a> * tree<'a>

let prettyPrintTree tree =
  let rec loop depth tree =
    let indentation = new String(' ', depth)
    match tree with
    | Leaf value -> printfn "%s |- %O" indentation value
    | Node (tree1, tree2) ->
      printfn "%s |" indentation
      loop (depth + 1) tree1
      loop (depth + 1) tree2
 
  loop 0 tree

let colorfulTree =
  Node(
    Leaf "Red",
    Node(
      Leaf "Blue",
      Node(
        Node(
          Leaf "Navy",
          Leaf "Fuchsia"
        ),
        Leaf "Maroon"
      )
    )
  )

let main () =
  prettyPrintTree colorfulTree

main()
