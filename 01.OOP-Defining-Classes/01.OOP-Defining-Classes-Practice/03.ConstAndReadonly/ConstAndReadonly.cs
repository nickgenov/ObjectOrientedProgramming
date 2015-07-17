using System;

class ConstAndReadonly
{
    static void Main()
    {
        Elephant e = new Elephant("Eli", 4500);
        Console.WriteLine(e.Weight);
        Console.WriteLine(e.Name);
        //e.Weight = 5000; //error - readonly field
    }
}