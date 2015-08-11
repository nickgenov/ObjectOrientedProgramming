using System;

namespace Inheritance_Example_Two.Classes
{
    public class Cat : Mammal
    {
        public Cat(int age) : base(age)
        {
            
        }

        public void SayMiau()
        {
            Console.WriteLine("Miau...");
        }
    }
}