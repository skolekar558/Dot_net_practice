using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public interface ITaxable
    {
        double PayTax();
    }
    //implicit implement of interface
    public class Job : ITaxable
    {
        private double salary = 1000;
        private double taxamount;
        public double PayTax()
        {
            taxamount = salary * 0.20;
            return taxamount;
        }
    }

    public class Buisiness : ITaxable
    {
        private double salary = 1000;
        private double taxamount;
        public double PayTax()
        {
            taxamount = salary * 0.30;
            return taxamount;
        }
    }
}
