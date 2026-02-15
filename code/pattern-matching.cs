// Pre C# 9
var nb = 42;
var text = nb switch
{
    int i when i &lt; 10 => "single digit",
    10 => "double digits",
    int i when i &lt; 100 => "double digits",
    int i when i &lt; 1000 => "triple digits",
    _ => "four or more digits"
};

// With C# 9 relational and conjunctive patterns
var nb = 42;
var text = nb switch
{
    &lt; 10 => "single digit",
    10 or (>= 11 and &lt; 100) => "double digits",
    &lt; 1000 => "triple digits",
    _ => "for or more digits",
};
// double digits