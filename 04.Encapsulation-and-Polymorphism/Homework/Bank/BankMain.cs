using System;
using System.Collections.Generic;
using Bank.Classes;
using Bank.Interfaces;

namespace Bank
{
    class BankMain
    {
        static void Main()
        {
            var a = new LoanAccount(new Company("M-tel", "Sofia", "0987654321"), 100000, 0.01m);

            var b = new MortgageAccount(new Individual("Petar Georgiev", "Sofia", 32), 10000, 0.01m);

            var c = new MortgageAccount(new Company("M-tel", "Sofia", "0987654321"), 100000, 0.01m);

            var d = new DepositAccount(new Individual("Stamat Stamatov", "Burgas", 44), 100, 0.005m);

            var e = new DepositAccount(new Individual("Minka Stamatova", "Burgas", 42), 1000, 0.005m);


            //1. Test interest rate calculations:
            TestInterestCalculations(a, b, c, d, e);

            //2. Test deposit functionality:
            TestDepositFunctionality(a, b, c, d, e);

            //3. Test withdraw functionality:
            TestWithdrawFunctionality(d, e);
        }

        private static void TestWithdrawFunctionality(DepositAccount d, DepositAccount e)
        {
            List<IWithdrawMoney> accountWithdraws = new List<IWithdrawMoney>() {d, e};

            foreach (var withdraw in accountWithdraws)
            {
                withdraw.WithdrawMoney(120);

                Account acc = (Account) withdraw;
                Console.WriteLine("{0}, balance {1:F2}", acc.GetType().Name, acc.Balance);
            }
        }

        private static void TestDepositFunctionality(LoanAccount a, MortgageAccount b, MortgageAccount c, DepositAccount d,
            DepositAccount e)
        {
            List<IDepositMoney> accountDeposits = new List<IDepositMoney>() {a, b, c, d, e};

            foreach (var deposit in accountDeposits)
            {
                deposit.DepositMoney(1100.50m);

                Account acc = (Account) deposit;
                Console.WriteLine("{0}, balance {1:F2}", acc.GetType().Name, acc.Balance);
            }
            Console.WriteLine();
        }

        private static void TestInterestCalculations(LoanAccount a, MortgageAccount b, MortgageAccount c, DepositAccount d,
            DepositAccount e)
        {
            List<ICalculateInterest> accountInterests = new List<ICalculateInterest>() {a, b, c, d, e};

            foreach (var account in accountInterests)
            {
                Console.WriteLine("{0}, balance {1:F2}", account.GetType().Name, account.CalculateInterest(24));
            }
            Console.WriteLine();
        }
    }
}