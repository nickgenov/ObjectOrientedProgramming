using System;

namespace _05.FiguresAndPoints
{
    class Point
    {
        private double x;
        private double y;

        public double X 
        {
            get { return this.x; }
            private set { this.x = value; }
        }
        public double Y 
        {
            get { return this.y; }
            private set { this.y = value;}
        }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
