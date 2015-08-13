using System;
using ComputerCatalog.Interfaces;

namespace ComputerCatalog.Classes
{
    public abstract class Component : IComponent
    {
        private string name;
        private decimal price;

        protected Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price cannot be negative.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            string output = string.Format("Component {0} - price: {1:F2}", this.Name, this.Price);
            return output;
        }
    }
}