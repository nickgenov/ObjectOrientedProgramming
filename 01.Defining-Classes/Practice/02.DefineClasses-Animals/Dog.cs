using System;

class Dog
{
    private string name;
    private string owner;

    public string Name
    {
        get { return this.name; }
        set 
        {
            if (value == string.Empty)
            {
                throw new ArgumentOutOfRangeException("Name cannot be empty.");
            }
            this.name = value;
        }
    }
    public string Owner
    {
        get { return this.owner; }
        set 
        {
            if (value == string.Empty)
            {
                throw new ArgumentOutOfRangeException("Owner cannot be empty.");
            }
            this.owner = value; 
        }
    }
    public Dog()
    {

    }
    public Dog(string name, string owner)
    {
        this.Name = name;
        this.Owner = owner;
    }
    public void Bark()
    {
        Console.WriteLine("Dog {0} says: Woof, woof!", this.name);
    }
}