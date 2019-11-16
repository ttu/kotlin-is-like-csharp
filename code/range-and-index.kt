val names = arrayOf("Anna", "Alex", "Brian", "Jill", "Jack")
val count = names.count()

for (i in names.slice(1 until count - 1)) {
    println("Person is called ${i}")
}
// Person is called Alex
// Person is called Brian
// Person is called Jill