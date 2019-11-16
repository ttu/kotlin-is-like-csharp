var client = new HttpClient();

var repos = new [] { "jetbrains/kotlin", "dotnet/csharplang" };

var asyncRequests = repos.Select(async repo =>
{
    var response = await client.GetAsync($"https://api.github.com/repos/{repo}");
    var json = await response.Content.ReadAsStringAsync();
    dynamic content = JsonConvert.DeserializeObject(json);
    return new { repo, stars = content.stargazers_count, forks = content.forks };
});

var results = await Task.WhenAll(asyncRequests);

foreach(var data in results)
    Console.WriteLine($"{data.repo} : {data.stars} - {data.forks}");