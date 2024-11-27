using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD2
{
    internal class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length = 1.0, double width = 1.0, double height = 1.0) 
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        public double volume()
        {
            return length * width * height;
        }
    }
}
