using System;

namespace Humans.Classes
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value >= 0)
                {
                    this.weekSalary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be a negative number!");
                }
                
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value >= 0)
                {
                    this.workHoursPerDay = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Work hours per day cannot be negative!");
                }
            }
        }

        public decimal MoneyPerHour()
        {
            decimal hoursWorked = 5 * this.WorkHoursPerDay;
            decimal moneyPerHour = this.WeekSalary / hoursWorked;

            return moneyPerHour;
        }
    }
}