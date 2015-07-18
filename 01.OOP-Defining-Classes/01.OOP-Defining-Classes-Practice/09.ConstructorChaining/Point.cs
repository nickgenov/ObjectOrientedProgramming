using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09.ConstructorChaining
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
            : this(0, 0)
        {

        }

        public Point(double x, double y)
        {
            this.XCoord = x;
            this.YCoord = y;
        }

        public double CalcDistance(Point p)
        {
            return Math.Sqrt(
                (p.XCoord - this.XCoord)*(p.XCoord - this.XCoord) + (p.YCoord - this.YCoord)*(p.YCoord - this.YCoord));
        }

        public static double CalcDistanceTwoPoints(Point a, Point b)
        {
            return Math.Sqrt(
                (a.XCoord - b.XCoord) * (a.XCoord - b.XCoord) + (a.YCoord - b.YCoord) * (a.YCoord - b.YCoord));
        }
    }
}