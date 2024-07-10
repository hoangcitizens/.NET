using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class AnalogClock
    {
        public void show(object clock, EventArgs info)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("AnalogClock: {0} giờ, {1} phút, {2} giây", date.Hour, date.Minute, date.Second);
        }
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += show;

        }
    }
}
