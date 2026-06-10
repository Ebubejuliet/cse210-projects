using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square sh1 = new Square("blue", 4);
        shapes.Add(sh1);
        Rectange sh2 = new Rectange("red", 4, 5);
        shapes.Add(sh2);
        Circle sh3 = new Circle(3, "green");
        shapes.Add(sh3);

        foreach (Shape sh in shapes)
        {
            string color = sh.GetColor();
            double area = sh.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}