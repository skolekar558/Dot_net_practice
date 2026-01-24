using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TreadDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            Thread t1 = new Thread(new ThreadStart(demo.Print1));
            Thread t2 = new Thread(new ThreadStart(demo.Print2));
            t1.Start();
            t2.Start();

        }
    }
}
