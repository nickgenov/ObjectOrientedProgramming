using System;
using System.Collections.Generic;

namespace Persons
{
    class PersonsMain
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

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}