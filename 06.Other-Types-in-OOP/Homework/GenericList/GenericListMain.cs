using System;

namespace GenericList
{
    class GenericListMain
    {
        static void Main()
        {
            var list = new GenericList<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine(list); //[10, 20, 30]
            Console.WriteLine("Max: {0}", list.Max()); //30
            Console.WriteLine("Min: {0}", list.Min()); //10

            Console.WriteLine(list[0]); //10
            Console.WriteLine(list[1]); //20

            //Exception:
            //Console.WriteLine(list[-1]);
            //Console.WriteLine(list[3]);

            list[1] = 150;
            Console.WriteLine(list);

            Console.WriteLine(list.Contains(150)); //true
            Console.WriteLine(list.Contains(1000)); //false

            Console.WriteLine(list.IndexOf(30)); //2
            Console.WriteLine(list.IndexOf(1000)); //-1

            list.InsertAtIndex(0, 1000);
            Console.WriteLine(list.ToString()); //[1000, 10, 150, 30]

            list.RemoveAtIndex(0);
            Console.WriteLine(list); //[10, 150, 30]

            //Exception:
            //list.RemoveAtIndex(-1);
            //list.RemoveAtIndex(3);
            //list.InsertAtIndex(-1, 40);
            //list.InsertAtIndex(3, 33);

            Console.WriteLine(list.Pop()); //30
            Console.WriteLine(list); //[10, 150]

            list.Push(-60);
            Console.WriteLine(list); //[10, 150, -60]

            list.Clear();
            Console.WriteLine(list); //[]
        }
    }
}