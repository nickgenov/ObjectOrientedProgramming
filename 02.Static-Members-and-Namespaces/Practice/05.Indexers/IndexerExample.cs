using System;

namespace _05.Indexers
{
    class IndexerExample
    {
        static void Main(string[] args)
        {
            BitArray32 bits = new BitArray32(368);

            //print the number bits
            for (int i = 31; i >= 0; i--)
            {
                Console.Write(bits.GetBit(i));
            }
            Console.WriteLine();

            bits.SetBitAt(1, 0);
            bits.SetBitAt(0, 5);

            Console.WriteLine(bits);

            //print the bits with the indexer
            for (int i = 31; i >= 0; i--)
            {
                Console.Write(bits[i]);
            }
            Console.WriteLine();

            bits[0] = 0;
            Console.WriteLine(bits);

            BitArray32 bits1 = new BitArray32(1500);
            BitArray32 bits2 = new BitArray32(2500);
            Console.WriteLine(bits1 + bits2);
        }
    }
}