using System;
using System.Collections.Generic;
using CompanyHierarchy.Classes;
using CompanyHierarchy.Enums;

namespace CompanyHierarchy
{
    class CompanyMain
    {
        static void Main()
        {
            var salesManager = new Manager(1, "Steve", "Ballmer", 250000, Department.Sales);
            var salesEmp1 = new SalesEmployee(3, "Stamat", "Stamatov", 2000, Department.Sales);
            var salesEmp2 = new SalesEmployee(4, "Minka", "Minkova", 2000, Department.Sales);
            salesEmp1.Sales.Add(new Sale("SQL Server 2014 Enterprise", DateTime.Now, 160000));
            salesEmp2.Sales.Add(new Sale("SQL Server 2014 Standard", DateTime.Now, 50000));

            salesManager.Employees.Add(salesEmp1);
            salesManager.Employees.Add(salesEmp2);

            var productionManager = new Manager(2, "Bill", "Gates", 725000, Department.Production);
            var developer1 = new Developer(5, "Pesho", "Peshev", 2500, Department.Production);
            var developer2 = new Developer(6, "Gosho", "Goshev", 2500, Department.Production);
            developer1.Projects.Add(new Project("Accounting module", DateTime.Now, string.Empty, ProjectState.Open));
            developer2.Projects.Add(new Project("Accounting module", DateTime.Now, string.Empty, ProjectState.Open));

            productionManager.Employees.Add(developer1);
            productionManager.Employees.Add(developer2);

            List<Person> people = new List<Person>()
            {
                salesManager,
                salesEmp1,
                salesEmp2,
                productionManager,
                developer1,
                developer2
            };

            foreach (var person in people)
            {
                Console.WriteLine("{0}\n", person);
            }
        }
    }
}