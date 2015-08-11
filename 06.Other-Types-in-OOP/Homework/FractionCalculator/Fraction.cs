using System;

namespace FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) 
            :this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Division by zero is an invalid operation. The denominator cannot be zero.");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            long numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            long denominator = a.Denominator * b.Denominator;

            var result = new Fraction(numerator, denominator);
            return result;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            long numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            long denominator = a.Denominator * b.Denominator;

            var result = new Fraction(numerator, denominator);
            return result;
        }

        public override string ToString()
        {
            decimal result = (decimal) this.Numerator / this.Denominator;
            return result.ToString();
        }
    }
}