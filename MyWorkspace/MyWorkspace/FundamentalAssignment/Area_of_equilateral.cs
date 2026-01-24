using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Write a program to calculate area of an equilateral triangle.
namespace MyWorkspace.FundamentalAssignment
{
    public class Area_of_equilateral
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side:");
            int a=Convert.ToInt32(Console.ReadLine());
            double area = (1.73/4)* a * a;
            Console.WriteLine(area);
        }
    }
}
