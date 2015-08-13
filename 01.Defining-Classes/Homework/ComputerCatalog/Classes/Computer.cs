using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerCatalog.Classes
{
    public class Computer
    {
        private string name;
        private decimal price;

        public Computer(string name)
        {
            this.Name = name;
        }

        public Computer(string name, decimal price)
            : this(name)
        {
            this.Price = price;
        }

        public Computer(string name, decimal price, List<Component> components)
            : this(name, price)
        {
            this.Components = components;
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

        public List<Component> Components { get; set; }

        public override string ToString()
        {
            string output = string.Format("Computer information:\nName: {0}\nPrice: {1:C} \nComponents: [{2}] \nComponents total price: {3}\n", this.Name, this.Price, string.Join(", ", this.Components), this.ComponentsTotalPrice);

            return output;
        }

        private decimal ComponentsTotalPrice
        {
            get
            {
                return this.Components.Sum(c => c.Price);
            }
        }
    }
}