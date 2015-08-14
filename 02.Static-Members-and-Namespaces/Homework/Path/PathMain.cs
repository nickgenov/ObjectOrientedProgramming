using System;
using Path.Classes;

namespace Path
{
    class PathMain
    {
        static void Main()
        {
            //load path from file
            string filePath = @"../../Files/PathToLoad.txt";
            Path3D loadedPath = Storage.LoadPathFromTextFile(filePath);

            foreach (var point in loadedPath.Points)
            {
                Console.WriteLine(point);
            }

            //save path to file
            Path3D path = new Path3D();
            path.Points.Add(new Point3D(3.2, 45.3, 234));
            path.Points.Add(new Point3D(22, 45.3, 234));
            path.Points.Add(new Point3D(34.3, 123, -21.2));

            string newFilePath = @"../../Files/PathToSave.txt";
            Storage.SavePathToTextFile(path, newFilePath);
        }
    }
}