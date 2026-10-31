using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Greatestno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no 1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no 2:");
            int n2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no 3:");
            int n3=Convert.ToInt32(Console.ReadLine());
            if ((n1 > n2)&&(n1 > n3))
            {
                Console.WriteLine("Greatest no:" + n1);
            }
            else if((n2>n1)&&(n2 > n3))
            {
                Console.WriteLine("Greatest no:" + n2);
            }
            else if((n3>n1)&&(n3 > n2))
            {
                Console.WriteLine("Greatest no:" + n3);
            }
            else
            {
                Console.WriteLine(" any of no is equal");
            }



                  
        }
    }
}
