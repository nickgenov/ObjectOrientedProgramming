using System;
using Interfaces_Figures.Classes;

namespace Interfaces_Figures
{
    class Figures
    {
        static void Main()
        {
            Circle c = new Circle(14.5);
            Console.WriteLine(c.CalcArea());

            Square a = new Square(45.3);
            Console.WriteLine(a.CalcArea());

            Rectangle r = new Rectangle(345.44,33.332);
            Console.WriteLine(r.CalcArea());
        }
    }
}