using System;
using System.Text.RegularExpressions;

namespace Bank.Classes
{
    public class Company : Customer
    {
        private string uic;

        public Company(string name, string address, string uic) 
            : base(name, address)
        {
            this.Uic = uic;
        }

        public string Uic
        {
            get
            {
                return this.uic;
            }

            set
            {
                if (ValidateUic(value))
                {
                    this.uic = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("uic", "Unique identification code must be exactly 10 digits long.");
                }
            }
        }

        private bool ValidateUic(string input)
        {
            Regex regex = new Regex(@"[0-9]{10}");

            if (regex.IsMatch(input))
            {
                return true;
            }

            return false;
        }
    }
}