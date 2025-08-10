using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Rojo", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("verde", 5, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("azul", 6);
        shapes.Add(circle);

        int shapeNumber = 1;
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"\nShape {shapeNumber}:");
            Console.WriteLine($"  Type: {shape.GetType().Name}");
            Console.WriteLine($"  Color: {shape.GetColor()}");
            Console.WriteLine($"  Area: {shape.GetArea()}");
            shapeNumber++;
        };

    }
}