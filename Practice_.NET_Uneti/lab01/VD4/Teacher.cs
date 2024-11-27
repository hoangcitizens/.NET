using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD4
{
    class Teacher : Person
    {
        private string subject;
        public void Teach()
        {
            Console.WriteLine("Bắt đầu giảng dạy !!!");
        }
    }
}
