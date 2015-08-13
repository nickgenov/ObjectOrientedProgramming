namespace ComputerCatalog.Interfaces
{
    public interface IComponent
    {
        string Name { get; set; }

        decimal Price { get; set; }
    }
}