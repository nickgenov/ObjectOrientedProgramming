using System;

namespace Interfaces_Figures.Classes
{
    public class Square : Figure
    {
        private double side;

        public Square(double side)
        {
            this.Side = side;
        }

        public double Side
        {
            get
            {
                return this.side;
            }
            set
            {
                if (value > 0)
                {
                    this.side = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side must be a positive number!");
                }
            }
        }

        public override double CalcArea()
        {
            double area = this.Side*this.Side;
            return area;
        }
    }
}