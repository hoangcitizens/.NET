using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event
{
    class Clock
    {
        public delegate void SecondChangeHander(object clock, EventArgs info);
        public event SecondChangeHander OnSecondChange;
        public void run() // phương thức kích hoạt sự kiện
        {
            while (true)
            {
                Thread.Sleep(1000);
                DateTime date = DateTime.Now;
                // Cứ mỗi giây lại gọi hàm xử lý sự kiện đăng kí
                if (OnSecondChange != null)
                    OnSecondChange(this, new EventArgs());
            }    
        }
    }
}
