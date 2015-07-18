using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SqrtPrecalculated
{
    static class SqrtPrecalculated
    {
        public const int MaxValue = 100000;

        //Static field
        private static int[] sqrtValues;

        //Static constructor
        static SqrtPrecalculated()
        {
            Console.WriteLine("Precalculating...");
            sqrtValues = new int[MaxValue + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }

        //Static method
        public static int GetSqrtValues(int i)
        {
            Console.WriteLine("Returned");
            return sqrtValues[i];
        }
    }
}