using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Min method is not public
//Main() M is in capital letter

namespace MyFirstApp
{
    public class MainMethodcs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"Addition is {c}");
        }
    }
}