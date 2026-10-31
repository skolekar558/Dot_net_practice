using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Palidromeno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;int temp = n;
            while(n > 0) {
                int rem = n % 10;
                n = n / 10;
                sum=sum*10+rem;
                Console.WriteLine(sum);
            }
            if (temp == sum)
            {
                Console.WriteLine("no is palidrome");
            }
            else
            {
                Console.WriteLine("no is not palidrome");
            }
        }
    }
}
