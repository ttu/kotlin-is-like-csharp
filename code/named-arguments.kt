fun area(width: Int, height: Int) = width * height
var result = area(width = 2, height = 3)

// This is also possible with named arguments
result = area(2, height = 2)
result = area(height = 3, width = 2)
