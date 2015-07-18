using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ConstructorChaining
{
    class ConstructorChaining
    {
        static void Main()
        {
            Point a = new Point(1, 2.5);
            Point b = new Point(233, 134.4);

            Console.WriteLine(a.CalcDistance(b));
            Console.WriteLine(b.CalcDistance(a));

            //use a static method instead:
            Console.WriteLine(Point.CalcDistanceTwoPoints(a, b));
        }
    }
}
