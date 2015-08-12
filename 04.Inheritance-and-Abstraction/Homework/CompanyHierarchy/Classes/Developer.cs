using System.Collections.Generic;
using CompanyHierarchy.Enums;

namespace CompanyHierarchy.Classes
{
    public class Developer : RegularEmployee
    {
        public Developer(int id, string firstName, string lastName, decimal salary, Department department) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = new List<Project>();
        }

        public List<Project> Projects { get; set; }
    }
}