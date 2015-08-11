using System;

namespace CustomStack
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Student anotherStudent)
        {
            if (this.Age > anotherStudent.Age)
            {
                return 1;
            }
            if (this.Age < anotherStudent.Age)
            {
                return -1;
            }

            return 0;
        }
    }
}