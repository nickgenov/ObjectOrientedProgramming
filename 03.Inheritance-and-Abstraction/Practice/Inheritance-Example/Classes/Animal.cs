using System;
using Inheritance_Example.Interfaces;

namespace Inheritance_Example
{
    public abstract class Animal : ISoundProduceable
    {
        private string name;
        private int age;
        private int numberOfLegs;

        protected Animal(string name, int age, int numberOfLegs)
        {
            this.Name = name;
            this.Age = age;
            this.NumberOfLegs = numberOfLegs;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int NumberOfLegs
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public abstract void ProduceSound();

        public abstract void Move();

        public void Eat()
        {
            Console.WriteLine("Hungry!");
        }

        public override string ToString()
        {
            return string.Format("Animal name: {0}, age: {1}, number of legs: {2}", this.Name, this.Age, this.NumberOfLegs);
        }
    }
}