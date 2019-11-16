public class DataPoint
{
    public int Id { get; set; }
    public double Celsius { get; set; }
    public DataPoint? Child { get; set; }
}
        
var data = new DataPoint 
{ 
    Id = 1, 
    Celsius = 22.1, 
    Child = new DataPoint { Id = 2, Celsius = 22.8 }
};

var result = data.Child?.Child != null
                ? ToFahrenheit(data.Child.Child.Celsius) 
                : double.MinValue;