fun transform(initial: String, f: (String) -> String) = f(initial)

val result = transform("hello", { x -> x.toUpperCase() })
// HELLO