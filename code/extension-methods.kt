fun MutableList&lt;Int>.swap(idx1: Int, idx2: Int) {
    val tmp = this[idx1]
    this[idx1] = this[idx2]
    this[idx2] = tmp
}

val list = mutableListOf(1, 5, 3)
list.swap(0, 2)
// [ 3, 5, 1 ]