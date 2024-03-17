type Transaction =
    {
        Name: string;
        Id: int;
        Status: string;
        IsProcesses: bool;
    }

// Something like a constructor.
let openTransaction name id = 
    { Name = name; Id = id; Status = null; IsProcesses = false }

let commitTransaction transaction =
    { transaction with Status = "Done"; IsProcesses = true }

let displayTransactionInfo message transaction =
    printfn "%s: %A" message transaction

[<EntryPoint>]
let main argv =
    let transaction = openTransaction "Withdrawal" 1
    let committed = commitTransaction transaction

    displayTransactionInfo "Uncommitted" transaction
    displayTransactionInfo "Committed" committed
    0