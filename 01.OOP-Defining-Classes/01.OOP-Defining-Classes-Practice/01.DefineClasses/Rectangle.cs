class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int Area
    {
        get
        {
            return this.Width * this.Height;
        }
    }

    public override string ToString()
    {
        return string.Format("Rect ({0}, {1})", this.Width, this.Height);
    }

    public void Print()
    {
        System.Console.WriteLine("I am a rectangle");
    }
}