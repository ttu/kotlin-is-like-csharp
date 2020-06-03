public class Customer
{
    public Customer(int id, string name) => (Id, Name) = (id, name);
    
    public int Id { get; }
    public string Name { get; }
}

var customer = new Customer(1, "Sachin");

var name = customer.Name;
customer.Id = 2 // Error