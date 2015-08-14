using System.Collections.Generic;

namespace Path.Classes
{
    public class Path3D
    {
        public Path3D()
        {
            this.Points = new List<Point3D>();
        }

        public Path3D(List<Point3D> points)
        {
            this.Points = points;
        }

        public List<Point3D> Points { get; set; }
    }
}