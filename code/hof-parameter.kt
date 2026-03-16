fun transform(initial: String, transformer: (String) -> String) = transformer(initial)

// Function reference
val result = transform("hello", String::uppercase)
// HELLO

// Trailing lambda can be placed outside the parentheses
val result2 = transform("hello") { it.uppercase() }