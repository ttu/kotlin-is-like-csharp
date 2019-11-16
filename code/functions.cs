string Greet(string name, string day)
{
    return $"Hello {name}, today is {day}";
}

var text = Greet("Bob", "Tuesday");
// Hello Bob, today is Tuesday

// One line functions can be without braces
int Double(int value) => value * 2;
var result = Double(4);
// 8