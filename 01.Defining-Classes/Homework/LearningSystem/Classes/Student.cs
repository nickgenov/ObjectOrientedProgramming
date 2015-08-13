using System;

namespace LearningSystem.Classes
{
    public abstract class Student : Person
    {
        private int studentNumber;
        private double averageGrade;

        protected Student(string firstName, string lastName, int age, int studentNumber, double averageGrade) 
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Student number must be positive.");
                }

                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Average grade cannot be under 2.");
                }

                this.averageGrade = value;
            }
        }
    }
}