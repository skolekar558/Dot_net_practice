using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Empex
    {
        static void Main(string[] args)
        {
            EmpInfo empInfo = new EmpInfo();
            foreach(Emp e in empInfo)
            {
                Console.WriteLine(e);
            }
           

            Emp Akshay = new Emp(101, "Akshay", 20000.0);
            Emp Vijay = new Emp(102, "Vijay", 40000.0);

            double result = Akshay.CompareTo(Vijay);

            if (result == 1)
            {
                Console.WriteLine("Akshay has more sal than vijay");
            }
            else if (result == -1)
            {
                Console.WriteLine("Akshay has less sal than vijay");
            }
            else
            {
                Console.WriteLine("both have equal sal");
            }

        }
    }
}
