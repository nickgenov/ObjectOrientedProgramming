using System;

namespace LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd, decimal price)
            : this (model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
        }

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, Battery battery, decimal price)
            : this (model, manufacturer, processor, ram, graphicsCard, hdd, price)
        {
            this.Screen = screen;
            this.Battery = battery;
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
                    throw new ArgumentException("Model name cannot be empty.");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Manufacturer name cannot be empty.");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Processor name cannot be empty.");
                }

                this.processor = value;
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("RAM cannot be empty.");
                }

                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Graphics cannot be empty.");
                }

                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("HDD cannot be empty.");
                }

                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Screen cannot be empty.");
                }

                this.screen = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price cannot be negative.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            if (this.Battery == null)
            {
                return string.Format(
                    "Laptop description:\nModel: {0}\nManufacturer: {1}\nProcessor: {2}\nRAM: {3}\nGraphics card: {4}\nHDD: {5}\nScreen: {6}\nBattery:\nBattery life:\nPrice: {7} lv.",
                    this.Model, this.Manufacturer, this.Processor, this.Ram, this.GraphicsCard, this.Hdd, this.Screen, this.Price);
            }

            return string.Format(
                "Laptop description:\nModel: {0}\nManufacturer: {1}\nProcessor: {2}\nRAM: {3}\nGraphics card: {4}\nHDD: {5}\nScreen: {6}\nBattery: {7}\nBattery life: {8} hours\nPrice: {9} lv.",
                this.Model, this.Manufacturer, this.Processor, this.Ram, this.GraphicsCard, this.Hdd, this.Screen, this.Battery.Model, this.Battery.BatteryLife, this.Price);
        }
    }
}