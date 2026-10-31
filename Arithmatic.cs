using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public  class Arithmatic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no1:");
            int n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no2:");
            int n2=Convert.ToInt32(Console.ReadLine());

            int add =n1+n2 ;
            int sub = n1 - n2;
            int mult = n1 * n2;
            int div = n1 / n2;
            Console.WriteLine("Addition is :"+add);
            Console.WriteLine("Substraction is :"+sub);
            Console.WriteLine("Multiplication is :"+mult);
            Console.WriteLine("Division is "+div);


        }
    }
}
