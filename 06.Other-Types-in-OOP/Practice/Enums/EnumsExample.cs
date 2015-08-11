using System;

namespace Enums
{
    class EnumsExample
    {
        static void Main()
        {
            DayOfWeek day = DayOfWeek.Tue;

            Console.WriteLine(day);
            Console.WriteLine((int)day);
            Console.WriteLine(++day);

            day = DayOfWeek.Sat;

            Console.WriteLine(++day);
            Console.WriteLine(++day);
            Console.WriteLine(++day);

            DayOfWeek newDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Wed");

            Console.WriteLine(newDay);

        }
    }
}