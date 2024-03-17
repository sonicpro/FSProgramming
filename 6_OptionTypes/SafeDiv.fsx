let unsafeDiv x y =
  x / y

// Evaluate the following in emacs as "region" by selecting it and pressing C-c C-r.
unsafeDiv 1 2

unsafeDiv 1 0


let safeDiv x y =
  match y with
  | 0 -> None
  | _ -> Some(x / y)

// Evaluate the following in emacs as "region" by selecting it and pressing C-c C-r.
safeDiv 1 2

safeDiv 1 0
