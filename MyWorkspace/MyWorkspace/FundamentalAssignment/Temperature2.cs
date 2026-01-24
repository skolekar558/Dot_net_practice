using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)
namespace MyWorkspace.FundamentalAssignment
{
    public class Temperature2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit(°F)");
            double f=Convert.ToDouble(Console.ReadLine());
            double cel = (f  - 32) * 5 / 9;
            Console.WriteLine($"Temperature in celcius={cel}");
        }
    }
}
