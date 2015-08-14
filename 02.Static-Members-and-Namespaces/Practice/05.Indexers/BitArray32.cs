using System;

namespace _05.Indexers
{
    public class BitArray32
    {
        private int number;

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public BitArray32(int number)
        {
            this.Number = number;
        }

        public int GetBit(int index)
        {
            if (index >= 0 && index <=31)
            {
                int bit = (this.Number >> index) & 1;
                return bit;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index must be in the range [0...31]!");
            }
        }

        public void SetBitAt(int bit, int index)
        {
            if (index < 0 || index > 31)
            {
                throw new ArgumentOutOfRangeException("Index must be in the range [0...31]!");
            }
            if (bit != 0 && bit != 1)
            {
                throw new ArgumentException("Bit must be 0 or 1!");
            }
            if (bit == 1)
            {
                this.Number |= (1 << index);
            }
            else if (bit == 0)
            {
                this.Number &= ~(1 << index);
            }
        }

        public int this[int index]
        {
            get { return this.GetBit(index); }
            set { this.SetBitAt(value, index); }
        }

        public override string ToString()
        {
            return this.Number.ToString();
        }

        public static BitArray32 operator +(BitArray32 a, BitArray32 b)
        {
            return new BitArray32(a.Number + b.Number);
        }
    }
}