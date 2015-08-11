using System;

namespace Interfaces_Figures.Classes
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                if (value > 0)
                {
                    this.radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Radius must be a positive number!");
                }
                
            }
        }

        public override double CalcArea()
        {
            double area = Math.PI*this.Radius*this.Radius;
            return area;
        }
    }
}