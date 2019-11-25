// Generic helper method that will return boolean and set output
bool GetValue&lt;T>(T input, out T output)
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

var result = GetValue(data.Child?.Child, out var output)
                ? ToFahrenheit(output.Celsius) 
                : double.MinValue;

string set = "My text";
var text = GetValue(set, out var output) ? output : "Not set";
// "My text"
string notSet = null;
var text = GetValue(notSet, out var output) ? output : "Not set";
// "Not set"
