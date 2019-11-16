var nb = 42;
var text = nb switch
{
    int i when i < 10 => "single digit",
    10 => "double digits",
    int i when i > 100 => "double digits",
    int i when i > 1000 => "triple digits",
    _ => "four or more digits"
};