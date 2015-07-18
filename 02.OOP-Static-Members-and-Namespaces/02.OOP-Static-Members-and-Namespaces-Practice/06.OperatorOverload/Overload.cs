using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OperatorOverload
{
    class Overload
    {
        static void Main()
        {
            Point a = new Point(3, 3);
            Point b = new Point(5, 5);

            //sum points :)
            Point c = a + b;
            Console.WriteLine(c);

            Point d = a*b;
            Console.WriteLine(d);

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a - b);

            //++ does NOT work, find why!
            Point e = a++;
            Console.WriteLine(e);
        }
    }
}