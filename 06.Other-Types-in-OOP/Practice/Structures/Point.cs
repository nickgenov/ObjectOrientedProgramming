namespace Structures
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Move(int deltaX, int deltaY)
        {
            this.X += deltaX;
            this.Y += deltaY;
        }
    }
}