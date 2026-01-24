using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.ConditionalStatements
{
    public class IfElseDemo
    {
        static void Main(string[] args)
        {
            int Marks = 16;
            if (Marks >= 35)
            {
                Console.WriteLine("you passed");
            }
            else
            {
                Console.WriteLine("you failed");
            }
        }
    }
}
