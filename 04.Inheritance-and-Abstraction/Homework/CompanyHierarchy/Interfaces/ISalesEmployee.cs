using System.Collections.Generic;
using CompanyHierarchy.Classes;

namespace CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
    }
}