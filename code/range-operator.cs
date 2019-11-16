var names = new[] { "Anna", "Alex", "Brian", "Jack" };
var count = names.Count();

foreach (var i in Enumerable.Range(0, count))
{
    Console.WriteLine($"Person {i + 1} is called {names[i]}");
}
// Person 1 is called Anna
// Person 2 is called Alex
// Person 3 is called Brian
// Person 4 is called Jack
