interface Nameable {
    fun name(): String
}

fun &lt;T: Nameable> genericFunction(x: T) {
    println("Name is " + x.name())
}

class Person : Nameable {
    override fun name() = "Person A"
}
