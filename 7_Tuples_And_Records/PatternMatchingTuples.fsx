let describeLocation = function
  | (0, 0) -> "At the origin"
  | (0, y) -> $"On the y-axis at {y}"
  | (x, 0) -> $"On the x-axis at {x}"
  | (x, y) -> $"At x={x}, y={y}"

describeLocation (12, 29)
