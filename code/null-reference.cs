// Nullable reference types are optional feature in C#

public class Measurement 
{ 
    public double Celsius { get; set; }
}

Measurement? data = null; // Ok: can be null
Measurement data = null; // Error: can't be null

void PrintMayBeNull(Measurement? data) 
{
    // data can be null, must have null check
    if (data == null)
        return;

    Console.WriteLine(data.Celsius);
}

void PrintNoNull(Measurement data) 
{
    // data can't be null. No need for check
    Console.WriteLine(data.Celsius);
}

Measurement? current = GetDataFromApi();

PrintMayBeNull(current); // No need for check as method accepts nulls

if (current == null)
    return; 

PrintNoNull(current); // OK: Null is checked before method call