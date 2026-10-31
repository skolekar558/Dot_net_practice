using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Swap
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 6;
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("n1=" + n1 + " " + "n2=" + n2);

        }
    }
}
