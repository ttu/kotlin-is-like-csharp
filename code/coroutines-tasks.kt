data class Stats(val full_name: String, val stargazers_count: Int = -1, val forks: Int = -1)

val mapper = jacksonObjectMapper().configure(DeserializationFeature.FAIL_ON_UNKNOWN_PROPERTIES, false)

val repos = listOf("jetbrains/kotlin", "dotnet/csharplang")

val asyncRequests = repos.map { repo ->
    GlobalScope.async {
        val body = Fuel.get("https://api.github.com/repos/${repo}")
            .responseString()
            .third.component1() // Fuel Result & Body
        body?.let { mapper.readValue<Stats>(it) } ?: Stats(repo)
    }
}

runBlocking {
    val results = asyncRequests.map { it.await() }
    results.forEach{ println("${it.full_name} : ${it.stargazers_count} - ${it.forks}") }
}