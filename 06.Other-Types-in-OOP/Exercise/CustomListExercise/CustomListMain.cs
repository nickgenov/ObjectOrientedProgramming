using System;
using System.Collections.Generic;

namespace CustomListExercise
{
    class CustomListMain
    {
        static void Main()
        {
            var list = new CustomList<int>();

            list.Add(-2);
            list.Add(12);
            list.Add(21);
            list.Add(33);

            Console.WriteLine(list.IndexOf(-2));
            Console.WriteLine(list.IndexOf(12));
            Console.WriteLine(list.IndexOf(21));
            Console.WriteLine(list.IndexOf(-22));
            Console.WriteLine(list);

            list.Remove(12);
            Console.WriteLine(list);

            list.Add(5);
            Console.WriteLine(list);

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());

            list[0] = 120;
            Console.WriteLine(list);

            Console.WriteLine(list[3]);
        }
    }
}