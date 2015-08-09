using System;

namespace Bank.Classes
{
    public abstract class Customer
    {
        private string name;
        private string address;

        protected Customer(string name, string address)
        {
            this.Name = name;
            this.Address = address;
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
                    throw new ArgumentNullException("name", "Name cannot be null, empty or whitespace");
                }

                this.name = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Address", "Address cannot be null, empty or whitespace");
                }

                this.address = value;
            }
        }
    }
}