using System;

namespace Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Name", "Name cannot be null, empty or whitespace.");
                }

                this.name = value;
            }

        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age must be in the range [1...100]");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null || value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email.");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, age: {1}, email: {2}", this.Name, this.Age, this.Email ?? "[no email]");
        }
    }
}