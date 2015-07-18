using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StaticExample
{
    class StaticExample
    {
        static void Main()
        {
            Person a = new Person("Stamat");
            Console.WriteLine("Person name: {0}", a.Name);
            Console.WriteLine("Persons count: {0}", Person.InstanceCounter);

            Person b = new Person("Minka");
            Console.WriteLine("Person name: {0}", b.Name);
            Console.WriteLine("Persons count: {0}", Person.InstanceCounter);

            for (int i = 0; i < 5; i++)
            {
                Person c = new Person("Nick");
                Console.WriteLine("Person name: {0}", c.Name);
                Console.WriteLine("Persons count: {0}", Person.InstanceCounter);
            }

        }
    }
}