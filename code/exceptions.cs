try 
{
    // Some code
}
catch (SomeException e) when (e.SomeCode == 404) 
{
    // Handle SomeException only when SomeCode is 404
}
catch (SomeException e) 
{
    // Handle SomeException
}
catch (Exception e) 
{
    // Handle rest of the Exceptions 
}
finally 
{
    // Optional finally block
}