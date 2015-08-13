using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ConstructorDefaultParameters
{
    class Orange
    {
        private decimal? price;

        public decimal? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Orange()
        {
            this.Price = null;
        }

        public Orange(decimal price)
        {
            this.Price = price;
        }

        public override string ToString()
        {
            if (this.Price != null)
            {
                return string.Format("I am an orange and my price is: {0}", this.Price);
            }
            else
            {
                return string.Format("I am an orange and my price is: [no price]");
            }

        }
    }
}
