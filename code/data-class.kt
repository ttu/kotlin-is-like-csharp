data class Customer(var id: Long, var name: String)

val customer = Customer(1, "Sachin")

val name = customer.name
customer.id = 2
