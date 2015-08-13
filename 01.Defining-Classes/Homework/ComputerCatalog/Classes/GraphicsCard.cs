using ComputerCatalog.Interfaces;

namespace ComputerCatalog.Classes
{
    public class GraphicsCard : Component, IDescription
    {
        public GraphicsCard(string name, decimal price) 
            : base(name, price)
        {
        }

        public GraphicsCard(string name, decimal price, string description)
            : base(name, price)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }
}