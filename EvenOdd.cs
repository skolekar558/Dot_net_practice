 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("number is even:" + n);
            }else if(n%2 == 1)
            {
                Console.WriteLine("number is odd:" + n);
            }
            else
            {
                Console.WriteLine("neigther even nor odd");
            }
        }
    }
}
