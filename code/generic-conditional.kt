// Use .let and forget weird helper methods

val data = DataPoint(1, 22.1, DataPoint(2, 22.8))

val result = data.child?.child?.
            let { toFahrenheit(it.celsius) } ?: Double.MIN_VALUE