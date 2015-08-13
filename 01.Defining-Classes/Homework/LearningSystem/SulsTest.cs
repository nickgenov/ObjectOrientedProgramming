using System;
using System.Collections.Generic;
using System.Linq;
using LearningSystem.Classes;

namespace LearningSystem
{
    class SulsTest
    {
        static void Main()
        {
            List<Person> people = new List<Person>()
            {
                new JuniorTrainer("Bogomil", "Dimitrov", 23),
                new SeniorTrainer("Atanas", "Rusenov", 22),
                new SeniorTrainer("Svetlin", "Nakov", 35),
                new JuniorTrainer("Filip", "Kolev", 29),
                new DropoutStudent("Stamat", "Stamatov", 38, 100023459, 2.83, "Could not pass the Fundamentals level."),
                new DropoutStudent("Kiril", "Kirilov", 24, 100023320, 3.96, "Started work."),
                new GraduateStudent("Ivan", "Yonkov", 24, 120034034, 5.76),
                new OnlineStudent("Ivan", "Ivanov", 24, 120034061, 4.65, "Databases"),
                new OnlineStudent("Petar", "Ivanov", 29, 120034088, 4.85, "Database Apps"),
                new OnlineStudent("Minka", "Ivanova", 31, 120033062, 5.32, "Advanced C#"),
                new OnlineStudent("Gergana", "Petrova", 27, 120035581, 3.79, "OOP"),
                new OnsiteStudent("Gosho", "Goshev", 26, 120035555, 4.29, "OOP", 6),
                new OnsiteStudent("Pesho", "Peshev", 24, 120035565, 4.68, "OOP", 5),
                new OnsiteStudent("Ivana", "Kirilova", 32, 120035786, 5.88, "OOP", 7),
                new OnsiteStudent("Maria", "Petrova", 33, 120035345, 5.03, "OOP", 7),
            };

            var currentStudents = people
                .Where(p => p is CurrentStudent)
                .Cast<CurrentStudent>()
                .OrderBy(s => s.AverageGrade);

            foreach (var student in currentStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}