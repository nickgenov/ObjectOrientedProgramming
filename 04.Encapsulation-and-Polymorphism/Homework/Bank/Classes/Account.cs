using System;
using Bank.Interfaces;

namespace Bank.Classes
{
    public abstract class Account : ICalculateInterest
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < -1000000 || value > 1000000)
                {
                    throw new ArgumentOutOfRangeException("balance", "Account balance must be in the range [-1000000...1000000].");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("interestRate", "Interest rate cannot be negative.");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal amount = this.Balance * (1 + this.InterestRate * months);
            return amount;
        }
    }
}