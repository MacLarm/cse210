using System;

class Program
{
    static void Main(string[] args)
    {
        double area;
        string color;
        List<Shape> shapes = new List<Shape>();
        Console.WriteLine();
        Square red = new Square(5,"red");
        Rectangle blue = new Rectangle(3,4,"blue");
        Circle green = new Circle(3,"green");
        shapes.Add(red);
        shapes.Add(blue);
        shapes.Add(green);

        foreach(Shape s in shapes)
        {
            area = s.GetArea();
            color = s.GetColor();
            Console.WriteLine($"the shape with the color {color} has an area of {area}");
            Console.WriteLine();
        }
    }
}