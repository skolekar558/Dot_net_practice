using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Calculate
    {
        public double CalculateArea(double length,double breadth)
        {
            return length * breadth;
        }
        public double CalculateArea(int width,int height) {
            return 0.5*width*height;
        }
        public double CalculateArea(double radius){
            return 3.14 * radius * radius;
        }
        public double CalculateArea(int side)
        {
            return side*side;
        }

    }
}
