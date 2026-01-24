using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.ConditionalStatements
{
    public class ElseIfDemo
    {
        static void Main(string[] args)
        {
            int Marks = 25;
            if (Marks <35)
            {
                Console.WriteLine("you are failed");
            }
            else if (Marks > 35)
            {
                Console.WriteLine("you are passed");
            }
            else
            {
                Console.WriteLine("you are equal to 35");
            }
        }

    }
}
