using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AutomaticProperties
{
    class AutomaticProperties
    {
        static void Main()
        {
            //this uses the PARAMETERLESS CONSTRUCTOR!
            UserProfile user = new UserProfile()
            {
                FirstName = "Nick",
                LastName = "Genov",
                UserId = 101,
            };
            Console.WriteLine(user);

            //the same thing as:
            UserProfile user2 = new UserProfile();
            user2.FirstName = "Stamat";
            user2.LastName = "Stamatov";
            user2.UserId = 1324;

            Console.WriteLine(user2);
        }
    }
}