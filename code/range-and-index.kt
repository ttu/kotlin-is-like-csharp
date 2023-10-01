val names = arrayOf("Anna", "Alex", "Brian", "Jill", "Jack")
val count = names.count()

for (name in names.slice(1..<count - 1)) {
    println("Person is called $name")
}
// Person is called Alex
// Person is called Brian
// Person is called Jill