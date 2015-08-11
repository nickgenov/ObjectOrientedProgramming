using System;
using Animals.Enums;

namespace Animals.Classes
{
    class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} (kitten) says: Miauuu!", this.Name);
        }
    }
}