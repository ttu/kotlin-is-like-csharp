class Shape 
{
    public int NumberOfSides { get; set; }
    public string SimpleDescription() => 
        $"A shape with {NumberOfSides} sides.";
}
