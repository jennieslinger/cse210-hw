using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Green", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Blue", 6, 8);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Purple", 2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Shape color is {color} and the area is {area}");
        }
    
    }
}