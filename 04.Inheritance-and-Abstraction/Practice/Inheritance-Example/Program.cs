using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance_Example.Classes;

namespace Inheritance_Example
{
    class Program
    {
        static void Main()
        {
            Dog sharo = new Dog("sharo", 5, "mente");

            sharo.ProduceSound();

            Console.WriteLine(sharo);
            sharo.Move();

        }
    }
}