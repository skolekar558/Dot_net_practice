using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public  class ITaxExtend
    {
        static void Main(string[] args)
        {
            Job j1 = new Job();
            j1.PayTax();

            Buisiness b1 = new Buisiness();
            b1.PayTax();
        }
    }
}
