using System;

namespace CompanyHierarchy.Classes
{
    public class Customer : Person
    {
        private decimal netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal netPurchaseAmount) 
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("NetPurchaseAmount", "NetPurchaseAmount cannot be negative.");
                }

                this.netPurchaseAmount = value;
            }
        }
    }
}