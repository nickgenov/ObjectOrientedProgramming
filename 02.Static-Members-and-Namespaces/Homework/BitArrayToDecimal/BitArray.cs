using System;
using System.Numerics;

namespace BitArrayToDecimal
{
    public class BitArray
    {
        private int bitArraySize;

        public BitArray(int size)
        {
            this.BitArraySize = size;
            this.Bits = new byte[BitArraySize];
        }

        public int BitArraySize
        {
            get
            {
                return this.bitArraySize;
            }
            set
            {
                if (value < 1 || value > 100000)
                {
                    throw new ArgumentOutOfRangeException("BitArraySize", "BitArraySize must be in the range [1...100000].");
                }

                this.bitArraySize = value;
            }
        }

        private byte[] Bits { get; set; }

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index >= this.BitArraySize )
                {
                    throw new ArgumentOutOfRangeException("Index", "Index out of range.");
                }

                return Bits[this.BitArraySize - 1 - index];
            }
            set
            {
                if (value > 1)
                {
                    throw new ArgumentOutOfRangeException("Bit", "Bits must be either 1 or 0.");
                }

                Bits[this.BitArraySize - 1 - index] = value;
            }
        }

        public override string ToString()
        {
            BigInteger decimalNum = ConvertBitArrayToDecimal();
            return decimalNum.ToString();
        }

        private BigInteger ConvertBitArrayToDecimal()
        {
            BigInteger power = 0;
            BigInteger decimalNum = 0;

            for (int i = this.Bits.Length - 1; i >= 0; i--)
            {
                if (Bits[i] == 1)
                {
                    decimalNum += RaiseTwoToPower(power);
                }
                power++;
            }

            return decimalNum;
        }

        private BigInteger RaiseTwoToPower(BigInteger power)
        {
            BigInteger result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
}