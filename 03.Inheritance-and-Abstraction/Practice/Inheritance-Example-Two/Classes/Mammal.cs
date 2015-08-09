using System;

namespace Inheritance_Example_Two.Classes
{
    public abstract class Mammal
    {
        private int age;

        protected Mammal(int age)
        {
            this.Age = age;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public void Sleep()
        {
            Console.WriteLine("Shhh! I'm sleeping.");
        }
    }
}