using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Persons
    {
        static void Main()
        {
            Person nick = new Person("Nick", 33);
            Person stamat = new Person("Stamat", 39, "Stamat@abv.bg");
            Person mimi = new Person("Mimi", 22, "mimeto@gmail.com");

            var people = new List<Person>()
            {
                nick,
                stamat,
                mimi
            };

            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }
    }
}