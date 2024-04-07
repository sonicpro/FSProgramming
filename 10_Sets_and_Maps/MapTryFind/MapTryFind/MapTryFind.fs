open System

let capitals = [ ("Australia", "Canberra");
    ("Canada", "Ottawa");
    ("China", "Beijing");
    ("Denmark", "Copenhagen");
    ("Egypt", "Cairo");
    ("Finland", "Helsinki");
    ("France", "Paris");
    ("Germany", "Berlin");
    ("India", "New Delhi");
    ("Japan", "Tokyo");
    ("Mexico", "Mexico City");
    ("Ukraine", "Kyiv");
    ("Slovenia", "Ljubljana");
    ("Spain", "Madrid");
    ("Sweden", "Stockholm");
    ("Taiwan", "Taipei");
    ("USA", "Wachington D.C.") ] |> Map.ofList

let rec programLoop() =
    Console.Write("Find a capital by country (type 'q' to quit): ")
    match Console.ReadLine() with
    | "q" -> Console.WriteLine("Exiting ...")
    | country ->
        match (capitals.TryFind country) with
        | Some(capital) -> Console.WriteLine("The capital of {0} is {1}\n", country, capital)
        | None -> Console.WriteLine("Country not found.\n")
        programLoop()

[<EntryPoint>]
let Main argv =
    programLoop()
    0


