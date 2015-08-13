using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AlarmClock
{
    class AlarmClockTest
    {
        static void Main()
        {
            AlarmClock a = new AlarmClock();
            a.Ring();

            AlarmClock b = new AlarmClock(6, 30);
            b.Ring();

            //AlarmClock c = new AlarmClock(33, 100); //Exception!
        }
    }
}
