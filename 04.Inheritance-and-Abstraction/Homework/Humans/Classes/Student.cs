using System.IO;
using System.Text.RegularExpressions;

namespace Humans.Classes
{
    public class Student : Human
    {
        private string facutlyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facutlyNumber;
            }
            set
            {
                string pattern = @"[\w]{5,10}";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(value);

                if (match.Success)
                {
                    this.facutlyNumber = value;
                }
                else
                {
                    throw new InvalidDataException("Faculty number must be digits and letters and between 5 and 10 symbols!");
                }
            }
        }
    }
}