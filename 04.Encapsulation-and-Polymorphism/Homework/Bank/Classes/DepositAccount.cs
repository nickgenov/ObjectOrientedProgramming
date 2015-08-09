using Bank.Interfaces;

namespace Bank.Classes
{
    public class DepositAccount : Account, IDepositMoney, IWithdrawMoney
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return this.Balance;
            }

            return base.CalculateInterest(months);
        }
    }
}