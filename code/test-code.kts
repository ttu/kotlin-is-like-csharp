// For sake of simplicity, some examples are missing some classes and functions

data class SensorData(var id: Int, var location: String, val value: Double)
data class Location(var location: String, val value: Double)

data class Movie(val id: Int, val name: String, val director: String)
data class Song(val id: Int)

val library = listOf(Movie(1, "A", "B"), Song(2))

open class Shape() {}
class Circle() : Shape() {}
class Square() : Shape() {}

val shape = Circle()

fun test(x : Shape) {
    val circle: Circle = x as Circle
    //val circle: Circle? = x as Circle?
    //val circle: Circle? = x as? Circle
    println(circle)
}

//test(Square())

fun toFahrenheit(celsius: Double) = (celsius * 9) / 5 + 32