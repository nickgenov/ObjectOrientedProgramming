using System;
using System.Collections.Generic;

namespace Point3D
{
    class PointMain
    {
        static void Main()
        {
            var points = new List<Point3D>()
            {
                new Point3D(),
                new Point3D(4, 10, 33),
                Point3D.StartingPoint
            };

            foreach (var point in points)
            {
                Console.WriteLine(point);
            }
        }
    }
}