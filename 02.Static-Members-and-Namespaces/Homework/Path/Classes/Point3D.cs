namespace Path.Classes
{
    public class Point3D
    {
        private static readonly Point3D StartingPoint3D = new Point3D(0, 0, 0);

        public Point3D()
            : this(1, 1, 1)
        {
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D StartingPoint
        {
            get
            {
                return Point3D.StartingPoint3D;
            }
        }

        public override string ToString()
        {
            string output = string.Format("Point ({0}, {1}, {2})", this.X, this.Y, this.Z);
            return output;
        }
    }
}