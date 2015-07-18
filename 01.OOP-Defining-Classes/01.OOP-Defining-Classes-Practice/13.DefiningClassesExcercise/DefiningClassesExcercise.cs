using System;
using System.Collections.Generic;

namespace _13.DefiningClassesExcercise
{
    class DefiningClassesExcercise
    {
        static void Main()
        {
            var sharo = new Dog("Sharo", "german shepherd");
            var bruno = new Dog("Bruno", "mastiff");
            var lisa = new Dog("Lisa", "terrier");
            var mongrel = new Dog("Smelly");
            var smelly = new Dog("Penka", "melez");

            var dogs = new List<Dog>() { sharo, bruno, lisa, mongrel, smelly };

            foreach (var dog in dogs)
            {
                dog.Bark();
            }

            Console.WriteLine();

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }
        }
    }
}
