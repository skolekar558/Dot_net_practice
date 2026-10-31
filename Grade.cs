using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyFirstApp
{
    public class Grade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sub1:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub2:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub3:");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub4:");
            int s4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub5:");
            int s5 = Convert.ToInt32(Console.ReadLine());
            int total = s1 + s2 + s3 + s4 + s5;
            double per = total / 5;
            Console.WriteLine("percentage=" + per);
            if (per >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if(per >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Grade D");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Grade E");
            }
            else if(per >= 40)
            {
                Console.WriteLine("Grade F");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
    }
}
