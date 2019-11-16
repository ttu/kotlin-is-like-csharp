// Kotlin doesn't have tuples, use data classes
data class GasPrices(val a: Double, val b: Double, val c: Double)

fun getGasPrices() = GasPrices(3.59, 3.69, 3.79)

val prices = getGasPrices();

val (a, b, c) = getGasPrices();