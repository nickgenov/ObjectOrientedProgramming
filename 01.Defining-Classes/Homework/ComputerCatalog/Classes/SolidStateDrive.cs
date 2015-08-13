using ComputerCatalog.Interfaces;

namespace ComputerCatalog.Classes
{
    public class SolidStateDrive : Component, IDescription
    {
        public SolidStateDrive(string name, decimal price) 
            : base(name, price)
        {
        }

        public SolidStateDrive(string name, decimal price, string description)
            : base(name, price)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }
}