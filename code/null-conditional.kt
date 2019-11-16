data class DataPoint(val id: Int, val celsius: Double, 
    val child: DataPoint? = null)

val data = DataPoint(1, 22.1, DataPoint(2, 22.8))

val result = data.child?.child?.
            let { toFahrenheit(it.celsius) } ?: Double.MIN_VALUE