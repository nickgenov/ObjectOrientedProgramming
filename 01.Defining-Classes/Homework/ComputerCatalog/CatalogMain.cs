using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using ComputerCatalog.Classes;

namespace ComputerCatalog
{
    public class CatalogMain
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            var laptopComponents = new List<Component>()
            {
                new Processor("Intel Core i5 4210U", 250),
                new Motherboard("HP Q77", 200),
                new Ram("8GB DDR3L", 120),
                new GraphicsCard("Intel HD graphics 4400", 0),
                new SolidStateDrive("Samsung 850 Evo 250GB", 220)
            };

            var desktopComponentsHigh = new List<Component>()
            {
                new Processor("Intel Core i7 4790K", 650),
                new Motherboard("Asus Z77-A", 250),
                new Ram("16GB DDR3 1600", 200),
                new GraphicsCard("Asus Strix GTX 970 4 GB", 700),
                new SolidStateDrive("Samsung 850 Evo 250GB", 220)
            };

            var desktopComponentsLow = new List<Component>()
            {
                new Processor("Intel Pentium G3258", 130),
                new Motherboard("H61", 120),
                new Ram("8GB DDR3 1600", 100),
                new GraphicsCard("Intel HD Graphics", 0),
                new SolidStateDrive("Adata SP920 120GB", 120)
            };

            var laptop = new Computer("HP 450 G2", 1100, laptopComponents);
            var desktopHigh = new Computer("High-End PC", 2200, desktopComponentsHigh);
            var desktopLow = new Computer("Low-End PC", 600, desktopComponentsLow);

            var computers = new List<Computer>()
            {
                laptop,
                desktopHigh,
                desktopLow
            };

            var sortedComputers = computers
                .OrderBy(c => c.Price);

            foreach (var computer in sortedComputers)
            {
                Console.WriteLine(computer);
            }
        }
    }
}