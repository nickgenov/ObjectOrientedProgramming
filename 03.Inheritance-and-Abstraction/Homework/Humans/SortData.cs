using System;
using System.Collections.Generic;
using System.Linq;
using Humans.Classes;

namespace Humans
{
    class SortData
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by faculty number in ascending order:

            //Faculty number validation DOES NOT WORK, fix it!
            var students = new List<Student>()
            {
                new Student("Petar", "Ivanov", "098234234"),
                new Student("Ivan", "Petrov", "554332334"),
                new Student("Stamat", "Georgiev", "445454452"),
                new Student("Maria", "Ivanova", "457432986"),
                new Student("Miroslava", "Popova", "546876097"),
                new Student("Lidiya", "Kirilova", "345678234"),
                new Student("Liliana", "Marinova", "234345234"),
                new Student("Veronika", "Dimitrova", "567897643"),
                new Student("Poli", "Ivanova", "775456456"),
                new Student("Mihail", "Petkov", "4567654345")
            };

            SortAndPrintStudents(students);

            //Initialize a list of 10 workers and sort them by payment per hour in descending order:
            var workers = new List<Worker>()
            {
                new Worker("Stamat", "Stamatov", 300, 8),
                new Worker("Minka", "Penkova", 330, 7),
                new Worker("Hasan", "Hasanov", 340, 8),
                new Worker("Mihail", "Dimitrov", 440, 6),
                new Worker("Penka", "Minchova", 220, 4),
                new Worker("Vilka", "Petrova", 200, 8),
                new Worker("Neli", "Mihaylova", 500, 4),
                new Worker("Mincho", "Minchev", 180, 4),
                new Worker("Stela", "Ivanova", 1200, 9),
                new Worker("Kirilka", "Popova", 450, 4),
            };
            
            SortAndPrintWorkers(workers);

            //Merge the lists and then sort them by first name and last name:
            MergeSortAndPrintHumans(students, workers);
        }

        private static void MergeSortAndPrintHumans(List<Student> students, List<Worker> workers)
        {
            var humansList = new List<Human>();
            humansList.AddRange(students);
            humansList.AddRange(workers);

            var sortedHumansList = humansList
                .OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName);

            foreach (var human in sortedHumansList)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }

        private static void SortAndPrintWorkers(List<Worker> workers)
        {
            var sortedWorkers = workers
                .OrderByDescending(w => w.MoneyPerHour());

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0} {1}, money per hour: {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            Console.WriteLine();
        }

        private static void SortAndPrintStudents(List<Student> students)
        {
            var sortedStudents = students
                .OrderBy(s => s.FacultyNumber);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}, faculty number: {2}", student.FirstName, student.LastName, student.FacultyNumber);
            }
            Console.WriteLine();
        }
    }
}