// Account class is defined in "implicit" style. We do not have to define the constructors using "new" keyword.

type Account(number: int, holder: string) =
  let mutable amount = 0m

  member x.Number = number
  member x.Holder = holder
  member x.Amount = amount

  member x.Deposit value = amount <- amount + value
  member x.Withdraw value = amount <- amount - value

// It seems that constructors are not curried functions, they rathe accept a tuple.
let orpheus = new Account (12345, "Orpheus")
let eureka = new Account (67890, "Eureka")

let transfer amount (source: Account) (target: Account) =
  source.Withdraw amount
  target.Deposit amount

let printAccount (x: Account) =
  printfn "AccountNo: %i, Name: %s, Funds available: %M" x.Number x.Holder x.Amount

let main () =
  let printAccounts () =
    [ orpheus; eureka ] |> List.iter printAccount

  orpheus.Deposit 50M
  eureka.Deposit 100M
  printAccounts ()

  printfn "\nTransferring half of funds from Eureka to Orpheus."
  transfer 50M eureka orpheus
  printAccounts ()

  printfn "\nTransferring $75 from Orheus to Eureka."
  transfer 75M orpheus eureka
  printAccounts ()

main ()
