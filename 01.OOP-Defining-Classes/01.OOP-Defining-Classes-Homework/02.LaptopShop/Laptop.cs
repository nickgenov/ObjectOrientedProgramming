using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private decimal price;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphics;
        private string hdd;
        private string screen;
        private Battery battery;

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model name cannot be empty.");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                this.price = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer name cannot be empty.");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Processor name cannot be empty.");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get { return this.ram; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("RAM cannot be empty.");
                }
                this.ram = value;
            }
        }

        public string Graphics
        {
            get { return this.graphics; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Graphics cannot be empty.");
                }
                this.graphics = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("HDD cannot be empty.");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new AggregateException("Screen cannot be empty.");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, string ram, string graphics, string hdd, string screen, Battery battery)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.Graphics = graphics;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }

        public Laptop(string model, decimal price, string processor, string ram, Battery battery)
        {
            this.Model = model;
            this.Price = price;
            this.Processor = processor;
            this.Ram = ram;
            this.Battery = battery;
        }

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public override string ToString()
        {
            if (this.Battery == null)
            {
                return string.Format(
                    "Laptop description\n\nModel: {0}\nManufacturer: {1}\nProcessor: {2}\nRAM: {3}\nGraphics card: {4}\nHDD: {5}\nScreen: {6}\nBattery:\nBattery life:\nPrice: {7} lv.",
                    this.Model, this.Manufacturer, this.Processor, this.Ram, this.Graphics, this.Hdd, this.Screen, this.Price);
            }
            else
            {
                return string.Format(
                    "Laptop description\n\nModel: {0}\nManufacturer: {1}\nProcessor: {2}\nRAM: {3}\nGraphics card: {4}\nHDD: {5}\nScreen: {6}\nBattery: {7}\nBattery life: {8} hours\nPrice: {9} lv.",
                    this.Model, this.Manufacturer, this.Processor, this.Ram, this.Graphics, this.Hdd, this.Screen, this.Battery.Model, this.Battery.BatteryLife, this.Price);
            }
        }
    }
}