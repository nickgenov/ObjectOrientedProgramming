using System;

namespace LearningSystem.Classes
{
    public abstract class CurrentStudent : Student
    {
        private string currentCourse;

        protected CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Course name cannot be empty.");
                }

                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            string output = string.Format("Name: {0} {1}\nAge: {2}\nStudent number: {3}\nAverage grade: {4}\nCurrent course: {5}\n", this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade, this.currentCourse);
            return output;
        }
    }
}