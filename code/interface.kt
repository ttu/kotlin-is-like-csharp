interface Nameable {
    fun name(): String
}

fun genericFunction&lt;T: Nameable>(x: T) {
    println("Name is " + x.name())
}
