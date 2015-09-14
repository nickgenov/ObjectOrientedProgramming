using System;

namespace DelegateExample
{
    public delegate void SimpleDelegate(string param);

    public class DelegateExample
    {
        static void Main()
        {
            SimpleDelegate del = new SimpleDelegate(TestMethod);
            del += TestMethod;
            del += Console.WriteLine;

            del("Hello");
        }

        static void TestMethod(string param)
        {
            Console.WriteLine("I was called by a delegate.");
            Console.WriteLine("I got a parameter: {0}", param);
        }

        static void Print()
        {
            Console.WriteLine("hi");
        }
    }
}