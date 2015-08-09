using System;

namespace Inheritance_Example_Two.Classes
{
    public class Dog : Mammal
    {
        private string breed;
        private string name;

        public Dog(int age, string name, string breed) : base(age)
        {
            this.Breed = breed;
            this.Name = name;
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void WagTail()
        {
            Console.WriteLine("{0} ({1}) wags tail!", this.Name, this.Breed);
        }
    }
}