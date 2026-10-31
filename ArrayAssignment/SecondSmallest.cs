using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class SecondSmallest
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 8, 9, 10, 11 };
            Array.Sort(a);
            int secsmall = a[1];
            Console.WriteLine(secsmall);
        }
    }
}
