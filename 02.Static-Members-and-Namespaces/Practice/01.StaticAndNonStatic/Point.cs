using System;

namespace StaticAndNonStatic
{
    class Point
    {
        private int xCoord;
        private int yCoord;

        public int XCoord
        {
            get { return this.xCoord; }
            set { this.xCoord = value; }
        }

        public int YCoord
        {
            get { return this.yCoord; }
            set { this.yCoord = value; }
        }

        public Point(int x, int y)
        {
            this.XCoord = x;
            this.YCoord = y;
        }

        public static Point Sum(Point a, Point b)
        {
            return new Point(a.XCoord + b.XCoord, a.YCoord + b.YCoord);
        }

        public override string ToString()
        {
            return string.Format("Point ({0}, {1})", this.XCoord, this.YCoord);
        }

        public void Print()
        {
            Console.WriteLine("Point ({0}, {1})", this.XCoord, this.YCoord);
        }
    }
}