using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.ConstructorDefaultParameters
{
    class Apple
    {
        public Apple()
        {
            this.Price = null;
        }
        public Apple(decimal price)
        {
            this.Price = price;
        }
        public decimal? Price { get; set; }
        public override string ToString()
        {
            return string.Format("I am an apple and my price is {0}", 
                this.Price.HasValue ? this.Price.ToString() : "[no price]");
        }
    }
}