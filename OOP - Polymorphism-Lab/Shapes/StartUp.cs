using System;
using System.Collections.Generic;

namespace Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(10, 20);
            Shape circle = new Circle(5);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.CalculatePerimeter());
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.Draw());
            }
        }
    }
}
