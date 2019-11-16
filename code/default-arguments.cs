void DisplayGreeting(string message, string name = "Guest") 
{
    Console.WriteLine($"Hello {name}, {message}");
}

DisplayGreeting("welcome!");
// Hello Guest, welcome!