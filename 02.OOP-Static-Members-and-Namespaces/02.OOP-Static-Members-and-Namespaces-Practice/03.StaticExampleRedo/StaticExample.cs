using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StaticExampleRedo
{
    class StaticExample
    {
        static void Main(string[] args)
        {
            Person a = new Person("Nick");
            Person b = new Person("Mimi");
            Person c = new Person("Desi");

            Console.WriteLine("Person name: {0}", a.Name);
            Console.WriteLine("Person name: {0}", b.Name);
            Console.WriteLine("Person name: {0}", c.Name);

            Console.WriteLine("Persons count: {0}", Person.InstanceCounter);

            Person d = new Person("Gosho");
            Console.WriteLine("Person name: {0}", d.Name);

            Console.WriteLine("Persons count: {0}", Person.InstanceCounter);

            //no setter to change the counter, as it should be
            //Person.InstanceCounter++;
        }
    }
}
