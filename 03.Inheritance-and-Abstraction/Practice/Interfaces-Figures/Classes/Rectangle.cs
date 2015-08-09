using System;

namespace Interfaces_Figures.Classes
{
    public class Rectangle : Figure
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public double SideA
        {
            get
            {
                return this.sideA;
            }
            set
            {
                if (value > 0)
                {
                    this.sideA = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side must be a positive number!");
                }
            }
        }
        public double SideB
        {
            get
            {
                return this.sideB;
            }
            set
            {
                if (value > 0)
                {
                    this.sideB = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side must be a positive number!");
                }
            }
        }

        public override double CalcArea()
        {
            double area = this.SideA*this.SideB;
            return area;
        }
    }
}