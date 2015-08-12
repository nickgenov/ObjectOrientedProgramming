using System;

namespace CompanyHierarchy.Classes
{
    public class Sale
    {
        private string productName;
        private decimal price;

        public Sale(string product, DateTime date, decimal price)
        {
            this.ProductName = product;
            this.Date = date;
            this.Price = price;
        }


        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("ProductName", "Product name cannot be null, empty or whitespace.");
                }

                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }

                this.price = value;
            }
        }
    }
}