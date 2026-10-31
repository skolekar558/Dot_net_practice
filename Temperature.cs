using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.	Write a program to enter temperature in °Celsius and convert it into °Fahrenheit Fahrenheit=(celsius*1.8)+32; 
namespace MyFirstApp
{
    public class Temperature
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in celcius:");
            double celcius=Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = (celcius * 1.8) + 32;
            Console.WriteLine($"Temperature in Farenheit={Fahrenheit}");
        }
    }
}
