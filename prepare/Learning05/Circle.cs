public class Circle : Shape
{
    private double _radius;
    private double PI = Math.PI;

    public Circle(double radius, string color) :base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Pow(_radius,2) * PI;
    }
}