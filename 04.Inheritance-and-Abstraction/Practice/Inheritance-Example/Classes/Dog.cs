using System;

namespace Inheritance_Example
{
    public class Dog : Animal
    {
        private const int DogNumberOfLegs = 4;

        private string breed;

        public Dog(string name, int age, string breed)
            : base (name, age, DogNumberOfLegs)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} says bark, bark!", this.Name);
        }

        public override void Move()
        {
            Console.WriteLine("{0} ({1}) moves!", this.Name, this.Breed);
        }

        public override string ToString()
        {
            string result = string.Format("{0}, breed: {1}", base.ToString(), this.Breed);

            return result;
        }
    }
}