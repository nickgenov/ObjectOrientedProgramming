using System.Collections.Generic;
using CompanyHierarchy.Enums;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Developer : RegularEmployee, IDeveloper
    {
        public Developer(int id, string firstName, string lastName, decimal salary, Department department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = new List<Project>();
        }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            string output = string.Format("{0}, projects: [{1}]", base.ToString(), string.Join(", ", this.Projects));
            return output;
        }
    }
}