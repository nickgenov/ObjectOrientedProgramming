using Bank.Interfaces;

namespace Bank.Classes
{
    public class LoanAccount : Account, IDepositMoney
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.GetType().Name == "Individual")
            {
                if (months > 3)
                {
                    months -= 3;
                }
                else
                {
                    months = 0;
                }
            }
            if (this.Customer.GetType().Name == "Company")
            {
                if (months > 2)
                {
                    months -= 2;
                }
                else
                {
                    months = 0;
                }
            }

            return base.CalculateInterest(months);
        }
    }
}