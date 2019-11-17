var datas = listOf(
    SensorData(1, "A", 2.89),
    SensorData(2, "B", 12.01),
    SensorData(3, "B", 11.89),
    SensorData(4, "A", 3.11),
    SensorData(5, "A", -456.0)
)

var avgs = datas
            .filter { it.value > -50.0 }
            .groupBy { it.location }
            .map { g -> 
                Location(g.key, 
                         g.value.map { it.value }.average()) }

// (location=A, value=3.0)
// (location=B, value=11.95)