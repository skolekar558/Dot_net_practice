using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyFirstApp
{
    public class Positive_Negative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            string result = (n > 0) ? "Number is positive" : ((n < 0) ? "Number is negative" : "Number is zero");
            Console.WriteLine(result);
        }
    }
}

