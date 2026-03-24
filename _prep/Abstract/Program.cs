var s = new Shape();
var c = new Circle(3);

Console.WriteLine($"Area is: {c.GetArea()}");

abstract class Shape()
{
    public abstract double GetArea();
}



class Circle : Shape
{
    public int Radius { get; init; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(this.Radius, 2);
    }
}
