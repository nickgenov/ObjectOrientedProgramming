using System;

namespace GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet) 
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < 0 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("latitude", "Latitude is between 0 and 90 degrees.");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("longitude", "Longitude is between -180 and 180 degrees.");
                }

                this.longitude = value;
            }
        }

        public Planet Planet
        {
            get
            {
                return this.planet;
            }
            set
            {
                if (value.GetType() != Planet.GetType())
                {
                    throw new InvalidOperationException("Invalid planet.");
                }

                this.planet = value;
            }
        }

        public override string ToString()
        {
            string output = string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);

            return output;
        }
    }
}