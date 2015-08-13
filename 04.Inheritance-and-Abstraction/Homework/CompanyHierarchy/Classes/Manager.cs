using System.Collections.Generic;
using CompanyHierarchy.Enums;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Manager : Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, decimal salary, Department department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }

        private string ListEmployees
        {
            get
            {
                string result = string.Join(", ", this.Employees);
                return result;
            }
        }

        public override string ToString()
        {
            string output = string.Format("---Manager {0}, employees: \n[{1}]", base.ToString(), this.ListEmployees);
            return output;
        }
    }
}