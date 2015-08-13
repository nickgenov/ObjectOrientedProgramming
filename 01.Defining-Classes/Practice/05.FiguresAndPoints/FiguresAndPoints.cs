using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FiguresAndPoints
{
    class FiguresAndPoints
    {
        static void Main()
        {
            var points = new Point[]
            {
                new Point(55.1, -4),
                new Point(7, -2),
                new Point(4, 4),
                new Point(55, -4),
            };

            var polygon = new Polygon(points);

            Console.WriteLine(polygon.Area);
        }
    }
}
