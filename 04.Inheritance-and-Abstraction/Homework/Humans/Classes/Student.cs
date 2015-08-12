using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Humans.Classes
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNum) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNum;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (ValidateFacultyNumber(value))
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException("Faculty number must be digits and letters and between 5 and 10 symbols!");
                }
            }
        }

        private static bool ValidateFacultyNumber(string value)
        {
            string pattern = @"^[\w]{5,10}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(value);

            if (match.Success)
            {
                return true;
            }

            return false;
        }
    }
}