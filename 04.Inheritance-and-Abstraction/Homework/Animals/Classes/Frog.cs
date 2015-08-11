using System;
using Animals.Enums;

namespace Animals.Classes
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} (frog) says: Kwak, kwak!", this.Name);
        }
    }
}