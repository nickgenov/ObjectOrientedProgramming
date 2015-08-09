using System;
using Animals.Enums;

namespace Animals.Classes
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} (tomcat) says: Meow, meow!", this.Name);
        }
    }
}