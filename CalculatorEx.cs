using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class CalculatorEx
    {
        static void Main(string[] args)
        {
            // hold the method reference

            Calculator c1 = new Calculator();

            // create object of delegate & pass the method name to hold the address

            MyDelegate mydelegate = new MyDelegate(c1.Add); // singlecast
            mydelegate += new MyDelegate(c1.Sub); // multicast
            mydelegate += new MyDelegate(c1.Mul);

            // to remove method from invocation list
            mydelegate -= new MyDelegate(c1.Sub);
            // to get the invocation list to retrieve the methods from delegate
            Delegate[] list = mydelegate.GetInvocationList();

            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(45, 34));
            }

            // this is in case of single cast delete
            //int result=mydelegate.Invoke(20, 40);
            //Console.WriteLine(result);

            // Invocation List --> delegate will create list & hold all method ref in sequence

            //Add
            //Sub
            //Mul


        }
    }
}
