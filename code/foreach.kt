val names = arrayOf("Anna", "Alex", "Brian", "Jack")
val count = names.count()

for (name in names) {
    println("Person is called $name")
}

names.forEach { println("Person is called $it") }

// Person is called Anna
// Person is called Alex
// Person is called Brian
// Person is called Jack