// C# 9 immutable records can be created with positional parameters
public record Customer(int Id, string Name);

Customer customer = new(1, "Sachin");
customer.Id = 2 // Error

// or with standard property syntac and init only setter
public record Customer
{
    public int Id { get; init; }
    public string Name { get; init; }
};

var customer = new Customer { Id  = 1, Name = "Sachin" };
customer.Id = 2 // Error

// Pre C# 9
public class Customer
{
    public Customer(int id, string name) => (Id, Name) = (id, name);
    
    public int Id { get; }
    public string Name { get; }
}

var customer = new Customer(1, "Sachin");

var name = customer.Name;
customer.Id = 2 // Error