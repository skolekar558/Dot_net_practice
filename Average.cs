using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.	Write a program to enter marks of five subjects and calculate total, average and percentage
namespace MyFirstApp
{
    public class Average
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
            int total=s1+s2+s3+s4+s5;
            float avg = total / 5;
            double per= (total / 500) * 100;
            Console.WriteLine($"total={total}\naverage={avg}\npercentage={per}");

        }
    }
}
