using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	Write a program to calculate area of an equilateral triangle.
namespace MyFirstApp
{
    public class Equilateral
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the side:");
            int a=Convert.ToInt32(Console.ReadLine());
            double area = (1.73 * a * a) / 4;
            Console.WriteLine(area);
        }
    }
}
