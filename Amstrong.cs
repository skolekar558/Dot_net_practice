using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Amstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no:");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;int res = n;
            while (n > 0)
            {
               int temp = n % 10;
                n = n / 10;
                Console.WriteLine(temp);
                sum +=temp*temp*temp;
            }
            Console.WriteLine(sum);
            if (res == sum)
            {
                Console.WriteLine("No is Amstrong no.");
            }
            else
            {
                Console.WriteLine("No is not amstrong no.");
            }
        }
    }
}
