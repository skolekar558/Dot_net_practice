using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Employee1
    {

        //declare the data members
        protected int empid;
        protected string empname;
        protected double bs, hra, pf, gross;

        //working with methods
        public Employee1()
        {
            empid = 1;
            empname = "Nitin";
            bs = 4000;
            hra = 2000;
            pf = 1000;
        }
        //method which accept the values from parameters
        public Employee1(int id, string name, double b, double h, double p)
        {
            empid = id;
            empname = name;
            bs = b;
            hra = h;
            pf = p;
        }
        public virtual void CalculateSalary()
        {
            gross = (bs + hra) - pf;
        }
        public virtual string Display()
        {
            return $"empid={empid},empname={empname},gross={gross}";
        }
    }
}
