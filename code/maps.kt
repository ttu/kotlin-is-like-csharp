val occupations = mapOf(
    "Malcolm" to "Captain",
    "Kaylee" to "Mechanic"
)

val occupationsMutable = mutableMapOf(
    "Malcolm" to "Captain",
    "Kaylee" to "Mechanic"
)
occupationsMutable["Jayne"] = "Public Relations"
occupationsMutable.put("Rick", "Navigation")
