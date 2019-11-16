open class NamedShape(val name: String) {
    var numberOfSides = 0

    open fun simpleDescription() =
        "A shape with $numberOfSides sides."
}

class Square(var sideLength: BigDecimal, name: String) :
        NamedShape(name) {
    init {
        numberOfSides = 4
    }

    fun area() = sideLength.pow(2)

    override fun simpleDescription() =
        "A square with sides of length $sideLength."
}

val square = Square(BigDecimal("5.2"), "square")
val area = square.area()
val desc = square.simpleDescription()
