using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Path.Classes
{
    public static class Storage
    {
        public static Path3D LoadPathFromTextFile(string filePath)
        {
            Path3D path = new Path3D();
            string[] rows = System.IO.File.ReadAllLines(filePath);

            foreach (var row in rows)
            {
                List<double> coordinates =
                    row.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

                double x = coordinates[0];
                double y = coordinates[1];
                double z = coordinates[2];
                Point3D point = new Point3D(x, y, z);

                path.Points.Add(point);
            }

            return path;
        }

        public static void SavePathToTextFile(Path3D path, string filePath)
        {
            foreach (var point in path.Points)
            {
                double x = point.X;
                double y = point.Y;
                double z = point.Z;
                string row = string.Format("{0} {1} {2}\n", x, y, z);

                using (TextWriter writer = new StreamWriter(filePath, true))
                {
                    writer.Write(row);
                }
            }
        }
    }
}