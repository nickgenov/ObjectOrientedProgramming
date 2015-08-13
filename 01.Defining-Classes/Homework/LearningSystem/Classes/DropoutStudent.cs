using System;

namespace LearningSystem.Classes
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Dropout reason cannot be empty.");
                }

                this.dropoutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine("Name: {0} {1}\nAge: {2}\nStudent number: {3}\nAverage grade: {4}\nDropout reason: {5}", this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade, this.DropoutReason);
        }
    }
}