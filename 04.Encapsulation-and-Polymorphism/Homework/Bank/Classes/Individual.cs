using System;

namespace Bank.Classes
{
    public class Individual : Customer
    {
        private int age;

        public Individual(string name, string address, int age) 
            : base(name, address)
        {
            this.Age = age;
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age cannot be a negative number.");
                }

                this.age = value;
            }
        }
    }
}