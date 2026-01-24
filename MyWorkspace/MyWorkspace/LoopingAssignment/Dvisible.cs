using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.	Write a Java program to check whether a number is divisible by 5 and 11 or not 
namespace MyWorkspace.LoopingAssignment
{
    public class Dvisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n%5==0 &&  n%11==0) {
                Console.WriteLine("no is divisible by 5 & 11:");
            }
            else
            {
                Console.WriteLine("no is not divisible by 5 & 11:");
            }
        }
    }
}
