var result = item switch
{
    Square s => Handle(s),
    Circle { Radius: &lt; 10 } c => HandleUnder10(c),
    Circle { Radius: 20 } c => Handle20(c),
    Circle c => Handle(c),
    _ => throw new Exception("Unknown shape")
};

// Same with if statements
if (item is Square s)
{ }
else if (item is Circle { Radius: &lt; 10 })
{ }
else if (item is Circle { Radius: 20 })
{ }
else if (item is Circle ci)
{ }