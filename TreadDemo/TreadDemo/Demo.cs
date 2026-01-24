using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TreadDemo
{
    public class Demo
    {

        public void Print1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        public void Print2()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

        }
    }
}
