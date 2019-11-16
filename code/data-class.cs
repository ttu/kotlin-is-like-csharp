// C# doesn't have data classes
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

var customer = new Customer { Id  = 1, Name = "Sachin" };

var name = customer.Name;
customer.Id = 2