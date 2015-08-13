public class Bird
{
    private string name;
    private string breed;
    private int age;

    public string Name 
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public Bird()
    { 
        
    }
    public Bird(string name, string breed, int age)
    {
        this.Name = name;
        this.Breed = breed;
        this.Age = age;
    }
    public void Sing()
    {
        System.Console.WriteLine("Bird {0} sings: chirp chirp!", this.Name);
    }
}