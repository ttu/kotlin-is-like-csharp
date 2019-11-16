int Area(int width, int height) => width * height;
var result = Area(width: 2, height: 3);

// This is also possible with named arguments
result = Area(2, height: 2);
result = Area(height: 3, width: 2);