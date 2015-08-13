using ComputerCatalog.Interfaces;

namespace ComputerCatalog.Classes
{
    public class Motherboard : Component, IDescription
    {
        public Motherboard(string name, decimal price) 
            : base(name, price)
        {
        }

        public Motherboard(string name, decimal price, string description)
            : base(name, price)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }
}