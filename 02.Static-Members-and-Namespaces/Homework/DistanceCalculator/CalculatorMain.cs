using System;
using DistanceCalculator.Classes;

namespace DistanceCalculator
{
    class CalculatorMain
    {
        static void Main()
        {
            Point3D a = new Point3D(5, 12, 34);
            Point3D b = new Point3D(23, 44, -1);

            double distance = Calculator.EuclideanDistanceBetweenPoints(a, b);
            Console.WriteLine(distance);
        }
    }
}