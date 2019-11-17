var names = new[] { "Anna", "Alex", "Brian", "Jill", "Jack" };

foreach (var name in names[1..^1])
{
    Console.WriteLine($"Person is called {name}");
}
// Person is called Alex
// Person is called Brian
// Person is called Jill
