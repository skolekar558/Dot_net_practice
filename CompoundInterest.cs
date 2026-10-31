using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.	Write a  program to enter P, T, R and calculate Compound Interest.A=P(1+R/100)T
namespace MyFirstApp
{
    public class CompoundInterest
    {
        static void Main(string[] args)
        {
            double principal = 10000, rate = 10.25, time = 5;
            double CI = principal * Math.Pow(1 + rate / 100, time);
            Console.WriteLine("Compound Interest: " + CI);

        }
    }
}
