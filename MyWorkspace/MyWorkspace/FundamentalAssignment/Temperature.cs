using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
namespace MyWorkspace.FundamentalAssignment
{
    public class Temperature
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in celcius");
            int cel=Convert.ToInt32(Console.ReadLine());
            double fareh = (cel * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit: "+fareh);
        }
    }
}
