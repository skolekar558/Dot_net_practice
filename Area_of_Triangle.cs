using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Area_of_Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width:");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            int h=Convert.ToInt32(Console.ReadLine());
            double area = 0.5 * b * h;
            Console.WriteLine(area);
        }
    }
}
