class Elephant
{
    private readonly string name;
    private readonly int weight;

    public string Name
    {
        get { return this.name; }
    }
    public int Weight
    {
        get { return this.weight; }
    }
    public Elephant(string name, int weight)
    {
        this.name = name;
        this.weight = weight;
    }
}