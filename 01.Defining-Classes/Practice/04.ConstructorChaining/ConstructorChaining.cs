using System;

class ConstructorChaining
{
    static void Main()
    {
        Rectangle rect = new Rectangle(5);
        Console.WriteLine(rect);
        Rectangle rect2 = new Rectangle(30, 20);
        Console.WriteLine(rect2.Area());
    }
}