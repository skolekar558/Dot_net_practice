using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write a program to enter marks of five subjects and calculate total, average and percentage
namespace MyWorkspace.FundamentalAssignment
{
    public class Marks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sub1 marks");
            int s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sub2 marks");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sub3 marks");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sub4 marks");
            int s4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sub5 marks");
            int s5 = Convert.ToInt32(Console.ReadLine());

            int total = s1 + s2 + s3 + s4 + s5;
            double avg = total / 5;
            double per = (total / 500.0) * 100;

            Console.WriteLine($"total={total} average={avg} per={per}");
        }
    }
}
