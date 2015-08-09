using System;
using System.Collections.Generic;
using Shapes.Classes;
using Shapes.Interfaces;

namespace Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            var shapes = new List<IShape>()
            {
                new Circle(5.3),
                new Rectangle(4.3, 6.6),
                new Rhombus(4, 4),
                new Circle(8.4),
                new Rectangle(5.5, 6.7)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0}: area: {1:F2}, perimeter: {2:F2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}