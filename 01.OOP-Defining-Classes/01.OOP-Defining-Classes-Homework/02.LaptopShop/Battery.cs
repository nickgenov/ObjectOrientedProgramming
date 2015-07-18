using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Battery
    {
        private string model;
        private double batteryLife;

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Battery model cannot be empty.");
                }
                this.model = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery life cannot be a negative number of hours.");
                }
                this.batteryLife = value;
            }
        }

        public Battery(string model, double batteryLife)
        {
            this.Model = model;
            this.BatteryLife = batteryLife;
        }
    }
}