using ComputerCatalog.Interfaces;

namespace ComputerCatalog.Classes
{
    public class Processor : Component, IDescription
    {
        public Processor(string name, decimal price) 
            : base(name, price)
        {
        }

        public Processor(string name, decimal price, string description)
            : base(name, price)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }
}