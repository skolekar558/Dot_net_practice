using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Write a  program to enter P, T, R and calculate Compound Interest.(p*(1+r/100)^t)
namespace MyWorkspace.FundamentalAssignment
{
    public class CompoundInterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal amount");
            int p=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time period ");
            int t=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate");
            float r=Convert.ToSingle(Console.ReadLine());
            double CI=p* Math.Pow((1+r/100),t)-p;
            Console.WriteLine($"Compound Interest={CI}");

        }
    }
}
