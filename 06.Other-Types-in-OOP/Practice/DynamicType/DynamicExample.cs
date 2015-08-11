using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace DynamicType
{
    class DynamicExample
    {
        static void Main(string[] args)
        {
           
        }

        static T Sum<T>(dynamic first, dynamic second)
        {
            return first + second;
        }

        static int Compare(dynamic first, dynamic second)
        {
            if (first == second)
            {
                return 0;
            }
            else
            {
                if (first < second)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
