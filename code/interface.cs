interface INameable 
{
    string Name();
}

void GenericMethod&lt;T>(T x) where T : INameable
{
    Console.WriteLine("Name is " + x.Name());
}

class Person : INameable
{
    public string Name() => "Person A";
}