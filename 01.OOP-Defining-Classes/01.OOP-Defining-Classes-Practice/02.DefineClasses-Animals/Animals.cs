using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefineClasses_Animals
{
    class Animals
    {
        static void Main(string[] args)
        {
            var Mimi = new Cat("Mimi", "Pesho");
            Console.WriteLine(Mimi.Name);

        }
    }
}
