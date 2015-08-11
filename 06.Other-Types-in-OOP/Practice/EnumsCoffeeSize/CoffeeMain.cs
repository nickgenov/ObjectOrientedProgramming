using System;

namespace EnumsCoffeeSize
{
    class CoffeeMain
    {
        static void Main()
        {
            var normalCoffee = new Coffee(CoffeeSize.Normal);
            var doubleCoffee = new Coffee(CoffeeSize.Double);

            Console.WriteLine(normalCoffee);
            Console.WriteLine(doubleCoffee);
        }
    }
}