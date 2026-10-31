using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class NegativeElement
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, -4, -5, 6, 7, 8, 8, 9 };
            int count = 0;
            Console.WriteLine("negative no of array");
            foreach (int i in nums)
            {
                if (i < 0)
                {
                    Console.Write(i + " ");
                    count++;
                }    
            }
            Console.WriteLine("Total negative no:" + count);
        }
        
        
    }
}
