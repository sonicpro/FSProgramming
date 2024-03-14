let map x f = (f x)

let square x = x * x

let cubeAndConvertToString x =
  let temp = x * x * x
  temp.ToString()

let answer x =
  if x then "yes"
  else "no"

// evaluate these statements as a region in emacs (C-c C-r).

let numericResult = map 5 square

let stringResult = map 5 cubeAndConvertToString

let booleanToString = map true answer
