using Bank.Interfaces;

namespace Bank.Classes
{
    public class MortgageAccount : Account, IDepositMoney
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.GetType().Name == "Company")
            {
                return CalculateInterestCompany(months);
            }
            if (this.Customer.GetType().Name == "Individual")
            {
                return CalculateInterestIndividual(months);
            }

            return base.CalculateInterest(months);
        }

        private decimal CalculateInterestCompany(int months)
        {
            if (months <= 12)
            {
                decimal amount = this.Balance * (1 + (this.InterestRate / 2) * months);
                return amount;
            }

            int halfRateMonths = 12;
            int fullRateMonths = months - halfRateMonths;

            decimal halfRateAmount = this.Balance * (1 + (this.InterestRate / 2) * halfRateMonths);
            decimal fullRateAmount = halfRateAmount * (1 + this.InterestRate * fullRateMonths);

            return fullRateAmount;
        }

        private decimal CalculateInterestIndividual(int months)
        {
            if (months <= 6)
            {
                return this.Balance;
            }

            int noRateMonths = 6;
            int fullRateMonths = months - noRateMonths;

            decimal amount = this.Balance * (1 + this.InterestRate * fullRateMonths);

            return amount;
        }
    }
}