using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance_Example_Two.Classes;

namespace Inheritance_Example_Two
{
    class Program
    {
        static void Main()
        {
            Dog pesho = new Dog(3, "pesho", "pincher");
            pesho.WagTail();

            Cat penka = new Cat(1);
            penka.SayMiau();
        }
    }
}