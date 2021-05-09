public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

var customer = new Customer { Id  = 1, Name = "Sachin" };

var name = customer.Name;
customer.Id = 2

// C# 9
// Records can be mutable, but they are primarily 
// intended for supporting immutable data models
public record Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}