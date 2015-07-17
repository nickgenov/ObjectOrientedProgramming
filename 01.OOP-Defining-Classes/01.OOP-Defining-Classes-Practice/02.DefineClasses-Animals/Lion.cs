public class Lion
{
    private string name;
    private int age;
    private int weight;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int Age 
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public int Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }

    public Lion()
    { 
        
    }
    public Lion(string name, int age, int weight)
    {
        this.Name = name;
        this.Age = age;
        this.Weight = weight;
    }
    public Lion(string name)
    {
        this.Name = name;
        this.Age = 2;
        this.Weight = 240;
    }

    public void Roar()
    {
        System.Console.WriteLine("Lion {0} roars: RAWR!!!", this.Name);
    }
}