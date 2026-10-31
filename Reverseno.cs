using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Reverseno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  no:");
            int n=Convert.ToInt32(Console.ReadLine());
            int res = 0;
            while(n>0)
            {
                int rem = n % 10;
                n = n / 10;
                
                res=res*10+rem;
               
            }
            Console.WriteLine(res);
        }

    }
}
