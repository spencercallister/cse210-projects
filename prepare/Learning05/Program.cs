using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];

        Square square = new("red", 5);
        shapes.Add(square);

        Rectangle rectangle = new("blue", 4, 6);
        shapes.Add(rectangle);

        Circle circle = new("yellow", 3);
        shapes.Add(circle);

        foreach (Shape shape in shapes) {
            Console.WriteLine($"The {shape.GetColor()} {shape.GetType()} has an area of {shape.GetArea()}.");
        }
    }
}