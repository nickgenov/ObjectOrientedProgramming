using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefineClasses_Animals
{
    class DefineClassesAnimals
    {
        static void Main(string[] args)
        {
            var mimi = new Cat();
            mimi.Owner = "Pehso";
            mimi.Name = "Mimi";

            var stamat = new Dog("Stamat", "Minka");
            stamat.Bark();

            Lion koss = new Lion("Koss", 2, 300);
            koss.Roar();

            Bird sparrow = new Bird();
            sparrow.Sing();
        }
    }
}
