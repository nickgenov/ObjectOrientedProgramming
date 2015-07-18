using System;

namespace StaticAndNonStatic
{
    class Static
    {
        static void Main()
        {
            Point a = new Point(3, 5);
            Point b = new Point(8, 12);

            Point sumPoint = Point.Sum(a, b);
            Console.WriteLine(sumPoint);

            //static Math class, there is no instance Math m = new Math();

            double sqrt = Math.Sqrt(10);
            Console.WriteLine(sqrt);

            a.Print();
        }
    }
}