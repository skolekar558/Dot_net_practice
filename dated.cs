using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class dated
    {
        static void Main(string[] args)
        {
            DateDemo d=new DateDemo();
            Console.WriteLine(d.Display());
            DateDemo d2=new DateDemo(23,04,2024);
            Console.WriteLine(d2.Display());
        }
    }
}
