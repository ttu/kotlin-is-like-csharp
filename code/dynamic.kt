// The dynamic type is not supported in code targeting the JVM
// https://kotlinlang.org/docs/reference/dynamic-type.html

// JSON example with data classes
data class Work(val name: String, val location: String)
data class User(val id: String, val work: Work)

val json = """[
    { "id": "A", "work": { "name": "ACME 2", "location": "NY" } },
    { "id": "B", "work": { "name": "Box Co", "location": "SF" } },
    { "id": "C", "work": { "name": "DotCom", "location": "NY" } }
]"""

val users =  jacksonObjectMapper().readValue&lt;List&lt;User>>(json)

val name = users.first().work.name
// ACME 2

val fromNy = users
              .filter { it.work.location == "NY" }
              .map { it.id }
// [A, C]