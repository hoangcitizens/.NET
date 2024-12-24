using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello     
        public string Giaiptb2(decimal a, decimal b, decimal c)
        {
            string kq = $"Nguyễn Hữu Hoàng <br>Phương trình {a} x^2 + {b}x + {c} = 0";
            if (a == 0)
            {
                if (b == 0)
                    return kq + "<br>Phương trình vô nghiệm !";
                else
                    return kq + $"<br>Phương trình có nghiệm x = {-c / b}";
            }    
            else
            {
                double delta = (double)(b * b - 4 * a * c);
                if (delta < 0)
                {
                    return kq + "<br>Phương trình vô nghiệm!";
                }
                else if (delta == 0)
                {
                    // Phương trình có nghiệm kép
                    decimal x = -b / (2 * a);
                    return kq + $"<br>Phương trình có nghiệm kép x1 = x2 = {x}";
                }
                else
                {
                    // Phương trình có 2 nghiệm phân biệt
                    double x1 = (-(double)b - Math.Sqrt(delta)) / (2 * (double)a);
                    double x2 = (-(double)b + Math.Sqrt(delta)) / (2 * (double)a);
                    return kq + $"<br>Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";
                }
            }    
            
        }
    }
}