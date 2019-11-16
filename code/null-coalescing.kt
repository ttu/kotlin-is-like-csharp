val data = DataPoint(1, 22.1, DataPoint(2, 22.8))

val result = data.child?.child?.celsius ?: Double.MIN_VALUE
// Double.MIN_VALUE