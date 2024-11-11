using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle("purple", 7);
        Square square = new Square("orange", 12);
        Rectangle rectangle = new Rectangle("aquamarine", 7, 6);

        List<Shape> shapes = [circle, square, rectangle];

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}