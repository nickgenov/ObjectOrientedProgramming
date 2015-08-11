namespace Structures
{
    class StructuresExample
    {
        static void Main()
        {
            Square square = new Square(
                new Point() { X = 5, Y = -3 },
                7,
                new Color() { RedValue = 73, GreenValue = 158, BlueValue = 76 },
                new Color() { RedValue = 0, GreenValue = 255, BlueValue = 133 },
                EdgeType.Rounded
                );
            System.Console.WriteLine(square);

            square.EdgeType = EdgeType.Straight;
            square.BorderColor = new Color()
            {
                RedValue = 0,
                GreenValue = 0,
                BlueValue = 0
            };


            Point oldLocation = square.Location;
            Point newLocation = new Point()
            {
                X = oldLocation.X + 10,
                Y = oldLocation.Y
            };

            square.Location = newLocation;

            //point is a value type - does not work!
            //square.Location.X = square.Location.X + 10; 

            System.Console.WriteLine(square);
        }
    }
}