using System;

namespace BitArrayToDecimal
{
    class BitArrayMain
    {
        static void Main()
        {
            var num = new BitArray(100000);

            // 1111 1111 is 255
            for (int i = 0; i < 8; i++)
            {
                num[i] = 1;
            }
            Console.WriteLine(num); // 255

            num[99999] = 1; // set the biggest bit to 1, it is a huge number!
            Console.WriteLine(num);
        }
    }
}