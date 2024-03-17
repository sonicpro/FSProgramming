let isFourtyTwo = function
  | Some(42) -> true
  | Some(_) | None -> false

// Evaluate the following in emacs as "region" by selecting it and pressing C-c C-r.
isFourtyTwo (Some 12)

isFourtyTwo (Some 42)

isFourtyTwo None
