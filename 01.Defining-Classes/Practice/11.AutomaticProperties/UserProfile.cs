using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AutomaticProperties
{
    class UserProfile
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public UserProfile(int userId, string firstName, string lastName)
        //{
        //    this.UserId = userId;
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //}

        public UserProfile()
        {
            
        }

        public override string ToString()
        {
            return string.Format("User {0}: {1} {2}", this.UserId, this.FirstName, this.LastName);
        }
    }
}
