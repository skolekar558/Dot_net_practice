using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.LoopingControlStatement
{
    public class WhileLoopDemo
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("printing element from 0-9");

            //print 0-9
            int j = 0;
            while(j<10) {
            Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("printing element from 9-0");
            //print 9-0
            int k = 9;
            while (k >= 0)
            {
                Console.WriteLine(k);
                k--;
            }

        }
    }
}
