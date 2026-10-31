using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Perfect
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
               if(n%i == 0)
                {
                    sum = sum + i;
                }
                
            }
            Console.WriteLine(sum);
            if(n==sum)
            {
                Console.WriteLine("It is an perfect no");
            }
            else
            {
                Console.WriteLine("Not a perfect no");
            }
        }
    }
}
