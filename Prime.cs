using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int n=Convert.ToInt32(Console.ReadLine());
            Boolean isprime = true;
            for(int i = 2; i < n / 2; i++)
            {
                if(n% i== 0)
                {
                    isprime = false;    
                } 
            }
            if(isprime==true) {
                Console.WriteLine("no is prime");
            }
            else
            {
                Console.WriteLine("no is not prime:");
            }
        }
    }
}
