using System;
using System.Collections.Generic;
using System.Linq;
using Animals.Classes;
using Animals.Enums;

namespace Animals
{
    class CalculateAverageAge
    {
        static void Main()
        {
            var animalsArray = new List<Animal>()
            {
                new Dog("Sharo", 2, Gender.Male),
                new Dog("Rex", 4, Gender.Male),
                new Dog("Mimi", 3, Gender.Female),
                new Frog("Pesho", 1, Gender.Male),
                new Frog("Penka", 1, Gender.Female),
                new Frog("Minka", 2, Gender.Female),
                new Frog("Kirilka", 3, Gender.Female),
                new Kitten("Lili", 1, Gender.Female),
                new Kitten("Juji", 2, Gender.Female),
                new Kitten("Geri", 1, Gender.Female),
                new Tomcat("Stamat", 3, Gender.Male),
                new Tomcat("Gosho", 6, Gender.Male),
                new Tomcat("Pesho", 2, Gender.Male),
            };

            var animalAverageAge = animalsArray
                .GroupBy(a => a.GetType().Name)
                .Select(a => new
                {
                    AnimalType = a.Key,
                    AverageAge = a.Average(b => b.Age)
                })
                .OrderBy(a => a.AverageAge);

            foreach (var animal in animalAverageAge)
            {
                Console.WriteLine("{0} average age: {1:F2}", animal.AnimalType, animal.AverageAge);
            }
        }
    }
}