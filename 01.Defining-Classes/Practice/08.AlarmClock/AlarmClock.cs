using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AlarmClock
{
    class AlarmClock
    {
        private int hours = 9; //Inline initialization
        private int minutes = 0; //Inline initialization

        public int Hours
        {
            get { return this.hours; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException("Invalid hour!");
                }
                this.hours = value; 
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("Invalid minute!");
                }
                this.minutes = value; 
            }
        }

        public AlarmClock()
        {
            
        }

        public AlarmClock(int hours, int minutes)
        {
            this.Hours = hours;  //Invoked after inline initalization!
            this.Minutes = minutes;  //Invoked after inline initalization!
        }

        public void Ring()
        {
            Console.WriteLine("It is {0} hours : {1} minutes, GET UP!!!", this.Hours, this.Minutes);
        }
    }
}