using System;

namespace LaptopShop
{
    public class Battery
    {
        private string model;
        private double batteryLife;

        public Battery(string model, double batteryLife)
        {
            this.Model = model;
            this.BatteryLife = batteryLife;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Battery model cannot be empty.");
                }

                this.model = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("BatteryLife", "Battery life cannot be a negative number of hours.");
                }

                this.batteryLife = value;
            }
        }
    }
}