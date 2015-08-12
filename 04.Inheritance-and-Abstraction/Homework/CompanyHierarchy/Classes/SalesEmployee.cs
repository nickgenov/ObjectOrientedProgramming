using System.Collections.Generic;
using CompanyHierarchy.Enums;

namespace CompanyHierarchy.Classes
{
    public class SalesEmployee : RegularEmployee
    {
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = new List<Sale>();
        }

        public List<Sale> Sales { get; set; }
    }
}