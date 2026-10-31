using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Area_of_circle
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("Enter the radius:");
            int r=Convert.ToInt32(Console.ReadLine());

            double area = pi * r * r;
            Console.WriteLine(area);
        }
    }
}
