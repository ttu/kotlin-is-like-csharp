data class Measurement(val celsius)

val data: Measurement = null // Error: can't be null
val data: Measurement? = null // Ok: can be null

fun printMayBeNull(data: Measurement?) {
    // data can be null, must have null check
    if (data == null)
        return

    println(it.celsius)
}

fun printNoNull(data: Measurement) {
    // data can't be null. No need for check
    println(data.celsius)
}

val current: Measurement? = getDataFromApi()

printMayBeNull(current) // Ok: can be null

if (current == null)
    return

printNoNull(current)
