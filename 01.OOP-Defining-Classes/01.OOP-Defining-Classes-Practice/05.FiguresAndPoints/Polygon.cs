using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FiguresAndPoints
{
    class Polygon
    {
        private IList<Point> points;

        public IList<Point> Points
        {
            get { return this.points; }
            set { this.points = value; }

        }
        public double Area
        {
            get
            {
                var area = Math.Abs(this.Points.Take(this.Points.Count - 1)
                    .Select((p, i) => (this.Points[i + 1].X - p.X) * (this.Points[i + 1].Y + p.Y))
                    .Sum() / 2.0);
                return area;
            }
        }

        public Polygon(IList<Point> points)
        {
            this.Points = points;
        }
    }
}