using System;

namespace DistanceCalculator.Classes
{
    public static class Calculator
    {
        public static double EuclideanDistanceBetweenPoints(Point3D a, Point3D b)
        {
            double distance = Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z));
            return distance;
        }
    }
}