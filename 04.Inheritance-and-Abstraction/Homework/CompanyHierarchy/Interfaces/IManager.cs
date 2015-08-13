using System.Collections.Generic;
using CompanyHierarchy.Classes;

namespace CompanyHierarchy.Interfaces
{
    public interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}