fun greet(name: String, day: String): String {
    return "Hello $name, today is $day."
}

val text = greet("Bob", "Tuesday")
// Hello Bob, today is Tuesday

// One line functions can be without braces
fun double(value: Int): Int = value * 2
val result = double(4)
// 8