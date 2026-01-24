using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.FundamentalAssignment
{
    internal class Primeno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int n=Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            for(int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if(isprime)
            {
                Console.WriteLine("no is prime");
            }
            else
            {
                Console.WriteLine("no is not prime");
            }
        }
    }
}
