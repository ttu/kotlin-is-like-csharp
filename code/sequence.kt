// Sequence is lazy
val seq = sequenceOf(1, 2, 3, 4)
    .filter { println("Filter $it, "); it % 2 == 1 }
    .map { println("Map $it, "); it * 2 }

// Computations are evaluated during terminal operation
val items = seq.toList()

// Filter 1,
// Map 1,
// Filter 2,
// Filter 3,
// Map 3,
// Filter 4,

// List is not lazy, so functions are evaluated immediately
val items2 = listOf(1, 2, 3, 4)
    .filter { println("Filter $it, "); it % 2 == 1 }
    .map { println("Map $it, "); it * 2 }

// Filter 1,
// Filter 2,
// Filter 3,
// Filter 4,
// Map 1,
// Map 3,