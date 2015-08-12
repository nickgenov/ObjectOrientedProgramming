using System;
using CompanyHierarchy.Enums;

namespace CompanyHierarchy.Classes
{
    public abstract class Employee : Person
    {
        private decimal salary;

        protected Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary", "Salary cannot be a negative number.");
                }

                this.salary = value;
            }
        }

        public Department Department { get; set; }
    }
}