using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//write code per for five subject marks
namespace MyFirstApp
{
    public  class Percentage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sub1:");
            int s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub2:");
            int s2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub3:");
            int s3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub4:");
            int s4=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub5:");
            int s5=Convert.ToInt32(Console.ReadLine()); 
            int sum=s1+s2+s3+s4+s5;

            double per = sum / 5;
            Console.WriteLine("Percentage="+per);
        }
    }
}
