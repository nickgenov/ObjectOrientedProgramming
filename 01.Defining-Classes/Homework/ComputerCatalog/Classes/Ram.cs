using ComputerCatalog.Interfaces;

namespace ComputerCatalog.Classes
{
    public class Ram : Component, IDescription
    {
        public Ram(string name, decimal price) 
            : base(name, price)
        {
        }

        public Ram(string name, decimal price, string description)
            : base(name, price)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }
}