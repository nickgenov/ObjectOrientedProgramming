using CompanyHierarchy.Enums;

namespace CompanyHierarchy.Interfaces
{
    public interface IEmployee
    {
        decimal Salary { get; set; }

        Department Department { get; set; }
    }
}