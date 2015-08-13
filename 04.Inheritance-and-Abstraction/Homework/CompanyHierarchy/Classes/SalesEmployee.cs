using System.Collections.Generic;
using CompanyHierarchy.Enums;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = new List<Sale>();
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {
            string output = string.Format("{0}, sold products: [{1}]", base.ToString(), string.Join(", ", this.Sales));
            return output;
        }
    }
}