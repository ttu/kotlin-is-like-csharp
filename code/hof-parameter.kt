fun transform(initial: String, f: (String) -> String) = f(initial)

val result = transform("hello", { x -> x.toUpperCase() })
// HELLO

// Trailing lambda can be placed outside the parentheses
val result2 = transform("hello") { x -> x.toUpperCase() }