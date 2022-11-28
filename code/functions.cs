string Greet(string name, string day)
{
    return $"Hello {name}, today is {day}.";
}

var text = Greet("Bob", "Tuesday");
// Hello Bob, today is Tuesday