// For sake of simplicity, some examples are missing some classes and functions

class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Director { get; set; }
}

class Song
{ 
    public int Id { get; set; } 
}

var library = new List<object> { new Movie { Id = 1, Name = "A", Director = "B " }, new Song { Id = 2 } };

private class Shape
{ }

private class Circle : Shape
{ }

private class Square : Shape
{ }

private void ConvertTest(Shape shape)
{
    var circle = (Circle)shape;
    var circle2 = shape as Circle;
}

public class SensorData
{
    public int Id { get; set; }
    public string Location { get; set; }
    public double Value { get; set; }
}

double ToFahrenheit(double celsius) => (celsius * 9) / 5 + 32;