open System

let shakespeare = "O Romeo, Romeo! wherefore art thou Romeo?"
// String.Split function is native-CLR, we must put arguments in parentheses.
let shakespeareArray = shakespeare.Split([| ' '; ','; '!'; '?' |],
    StringSplitOptions.RemoveEmptyEntries)
// Array is IEnumerable, so Set.ofSeq is the right method to create a Set from Array.
let shakespeareSet = Set.ofSeq shakespeareArray

let printCollection message collection =
    printfn "%s:" message
    Seq.iteri (fun index item -> printfn " %i %O" index item) collection

[<EntryPoint>]
let Main argv =
    printfn "sheakspeare: %A" shakespeare
    printCollection "shakespeareArray" shakespeareArray
    printCollection "shakespeareSet" shakespeareSet
    0

