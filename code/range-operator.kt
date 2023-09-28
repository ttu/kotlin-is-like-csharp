val names = arrayOf("Anna", "Alex", "Brian", "Jack")
val count = names.count()

for (i in 0..<count) {
    println("Person ${i + 1} is called ${names[i]}")
}
// Person 1 is called Anna
// Person 2 is called Alex
// Person 3 is called Brian
// Person 4 is called Jack
