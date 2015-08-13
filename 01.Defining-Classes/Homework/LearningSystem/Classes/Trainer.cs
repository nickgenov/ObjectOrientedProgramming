using System;

namespace LearningSystem.Classes
{
    public abstract class Trainer : Person
    {
        protected Trainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course {0} created.", courseName);
        }
    }
}
