using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test individual shapes
        Console.WriteLine("Testing Individual Shapes:");
        Console.WriteLine("-------------------------");

        Square square = new Square("Red", 5);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea():F2}");

        Console.WriteLine();

        // Create a list of shapes (demonstrating polymorphism)
        Console.WriteLine("List of Shapes (Polymorphism Demo):");
        Console.WriteLine("-----------------------------------");

        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("Yellow", 4));
        shapes.Add(new Rectangle("Purple", 5, 3));
        shapes.Add(new Circle("Orange", 2.5));
        shapes.Add(new Square("Pink", 7));
        shapes.Add(new Rectangle("Brown", 8, 2));

        // Iterate through the list and display each shape's properties
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}");
            Console.WriteLine($"  Color: {shape.GetColor()}");
            Console.WriteLine($"  Area: {shape.GetArea():F2}");
            Console.WriteLine();
        }
    }
}