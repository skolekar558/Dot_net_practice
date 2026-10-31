using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class UserInput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your salary:");
            double sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hello {name}, your age is {age} and salary is {sal}");
        }
    }
}
