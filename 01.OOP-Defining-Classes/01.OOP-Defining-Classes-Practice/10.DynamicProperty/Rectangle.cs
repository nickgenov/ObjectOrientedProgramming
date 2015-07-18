using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DynamicProperty
{
    class Rectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be a positive number!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be a positive number!");
                }
                this.height = value;
            }
        }

        public double Area
        {
            get { return this.Width * this.Height; }
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Rectangle(double size)
            : this(size, size)
        {

        }

        public override string ToString()
        {
            return string.Format("I am a rectangle ({0}, {1}) and my area is {2}", this.Width, this.Height, this.Area);
        }
    }
}
