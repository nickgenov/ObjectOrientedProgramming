using System;
public class Square
{
    private int size;

    public int Size 
    {
        get 
        { 
            return this.size; 
        }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Size should be a positive number.");
            }
            this.size = value; 
        }
    }
    public Square (int size)
    {
        this.Size = size;
    }

    public int Area()
    {
        return this.Size * this.Size;
    }
}
