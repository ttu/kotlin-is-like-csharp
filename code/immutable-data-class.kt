data class Customer(val id: Long, val name: String)

val customer = Customer(1, "Sachin")

val name = customer.name
customer.id = 2 // Error
