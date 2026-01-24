using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Write a Java program to find maximum between three numbers 
namespace MyWorkspace.LoopingAssignment
{
    public class MaxNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no.1");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no.2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no.3");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if(n1>n2 && n1 > n3)
            {
                Console.WriteLine("greater no is n1:" + n1);
            }
            else if(n2>n3 && n2 > n1)
            {
                Console.WriteLine("greater no is n2:" + n2);

            }
            else if(n3>n1 && n3 > n2)
            {
                Console.WriteLine("greater no is n3:" + n3);
            }
        }
    }
}
