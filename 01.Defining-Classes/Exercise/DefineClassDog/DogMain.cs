using System.Collections.Generic;

namespace DefineClassDog
{
    class DogMain
    {
        static void Main()
        {
            var dogs = new List<Dog>()
            {
                new Dog("Sharo", "melez"),
                new Dog(),
                new Dog("Rex", "terrier")
            };

            foreach (var dog in dogs)
            {
                dog.Bark();
            }
        }
    }
}