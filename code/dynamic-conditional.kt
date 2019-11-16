// The dynamic type is not supported in code targeting the JVM
// https://kotlinlang.org/docs/reference/dynamic-type.html

// Use .let and forget weird helper methods

val data = DataPoint(1, 22.1, DataPoint(2, 22.8))

val result = data.child?.child?.
            let { toFahrenheit(it.celsius) } ?: Double.MIN_VALUE