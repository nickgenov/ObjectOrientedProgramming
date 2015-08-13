using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ConstructorDefaultParameters
{
    class Point
    {
        private double xCoord;
        private double yCoord;

        public double XCoord
        {
            get { return this.xCoord; }
            set { this.xCoord = value; }
        }

        public double YCoord
        {
            get { return this.yCoord; }
            set { this.yCoord = value; }
        }

        public Point()
        {
            this.XCoord = 0;
            this.YCoord = 0;
        }

        public Point(double x, double y)
        {
            this.XCoord = x;
            this.YCoord = y;
        }
    }
}
