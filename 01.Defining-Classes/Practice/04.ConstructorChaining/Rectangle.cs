class Rectangle
{
    private readonly double width;
    private readonly double height;

    public double Width
    {
        get { return this.width; }
    }
    public double Height
    {
        get { return this.height; }
    }

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    //chaining uses an existing constructor:
    public Rectangle(double size) : this(size, size)
    {
   
    }
    public void Print()
    {
        System.Console.WriteLine("I am a Rectangle ({0}, {1})", this.Width, this.Height);
    }
    public override string ToString()
    {
        return string.Format("Rectangle ({0}, {1})", this.Width, this.Height);
    }
    public double Area()
    {
        return this.Width * this.Height;
    }
}