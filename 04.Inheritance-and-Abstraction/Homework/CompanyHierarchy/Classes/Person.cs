using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id", "Id cannot be negative.");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("FirstName", "First name cannot be null, empty or whitespace.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("LastName", "Last name cannot be null, empty or whitespace.");
                }

                this.lastName = value;
            }
        }

        protected string FullName
        {
            get
            {
                string fullName = string.Format("{0} {1}", this.FirstName, this.LastName);
                return fullName;
            }
        }

        public override string ToString()
        {
            string output = string.Format("Id: {0}, Full name: {1}", this.Id, this.FullName);
            return output;
        }
    }
}