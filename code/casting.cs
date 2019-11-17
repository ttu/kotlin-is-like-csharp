// Unsafe (throw exception)
var circle = (Circle)shape;

// Safe (return null)
var circle = shape as Circle;

// If Nullable reference types enabled (optional feature)
Circle? circle = shape as Circle;