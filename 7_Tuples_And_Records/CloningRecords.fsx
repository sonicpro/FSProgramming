type coords = { X: float; Y: float }

let setX previousCoords x = { previousCoords with X = x }

let start = { X = 1.0; Y = 1.0 }

let finish = setX start 15.5

// Evaluate the following in emacs as "region" by selecting it and pressing C-c C-r.

start

finish
