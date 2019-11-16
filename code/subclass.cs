class NamedShape
{
    private readonly string _name;

    public NamedShape(string name) => _name = name;

    protected int NumberOfSides { get; set; }

    public virtual string SimpleDescription() =>
         $"A shape with {NumberOfSides} sides.";
}

class Square: NamedShape
{
    private readonly double _sideLength;

    public Square(double sideLength, string name) : base(name)
    {
        _sideLength = sideLength;
        NumberOfSides = 4;
    }

    public double Area() => Math.Pow(_sideLength, 2);

    override public string SimpleDescription() =>
        $"A square with sides of length {_sideLength}.";
}

var square = new Square(5.2, "square");
var area = square.Area();
var desc = square.SimpleDescription();
