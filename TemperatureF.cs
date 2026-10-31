using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.	Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)
namespace MyFirstApp
{
    public class TemperatureF
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Fahrenheit");
            double fahrenheit=Convert.ToDouble(Console.ReadLine());
            double celcius= (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius: " + celcius.ToString("0.00") + " °C");

        }
    }
}
