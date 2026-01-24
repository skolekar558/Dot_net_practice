using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Write a program to check whether a year is leap year or not 
namespace MyWorkspace.LoopingAssignment
{
    public class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year:");
            int year=Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a Leap Year");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year");
            }
        }
         
        }
    }

