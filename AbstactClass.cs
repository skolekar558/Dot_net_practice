using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
   public abstract class AbstactClass
    {
       public int a { get; set; }
    }
    interface I1
    {
       int a{  get; set; } 
    }
    class child:AbstactClass,I1
    {
        public void add()
        {
            int sum = a + base.a;
            Console.WriteLine("Addition ="+sum);
        }
    }
}
