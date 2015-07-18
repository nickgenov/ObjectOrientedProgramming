using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.ConstructorDefaultParameters
{
    class ConstructorDefaultParameters
    {
        static void Main(string[] args)
        {
            Apple a = new Apple(4.4M);
            Console.WriteLine(a.Price);
            Console.WriteLine(a);
        
            Apple b = new Apple(3);
            Console.WriteLine(b);

            Apple c = new Apple();
            Console.WriteLine(c);

            Orange o = new Orange(10.4m);
            Console.WriteLine(o);

            Orange p = new Orange();
            Console.WriteLine(p);
        }
    }
}
