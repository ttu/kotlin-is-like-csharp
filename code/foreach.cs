var names = new List&lt;string> { "Anna", "Alex", "Brian", "Jack" };

foreach (var name in names)
{
    Console.WriteLine($"Person is called {name}");
}

names.ForEach(name => Console.WriteLine($"Person is called {name}"));

// Person is called Anna
// Person is called Alex
// Person is called Brian
// Person is called Jack