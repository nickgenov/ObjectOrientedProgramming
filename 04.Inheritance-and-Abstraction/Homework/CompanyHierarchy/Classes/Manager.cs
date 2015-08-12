using System.Collections.Generic;
using CompanyHierarchy.Enums;

namespace CompanyHierarchy.Classes
{
    public class Manager : Employee
    {
        public Manager(int id, string firstName, string lastName, decimal salary, Department department) : base(id, firstName, lastName, salary, department)
        {
            this.Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }
    }
}