// Dynamic helper method that will return boolean and set output
bool GetValue(dynamic? input, out dynamic? output)
{
    output = input;
    return output != null;
}

var data = new DataPoint 
{ 
    Id = 1, 
    Celsius = 22.1, 
    Child = new DataPoint { Id = 2, Celsius = 22.8 }
};

var result = GetValue(data.Child?.Child?.Celsius, out var output)
                ? ToFahrenheit(output) 
                : double.MinValue;

var text = GetValue("My text", out var output) ? output : "Not set";
// "My text"
var text = GetValue(null, out var output) ? output : "Not set";
// "Not set"
