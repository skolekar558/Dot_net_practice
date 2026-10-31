using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Emp
    {
        private int id;
        private string name;
        private double salary;
        public Emp(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public double CompareTo(Emp? other) {
            if (this.salary > other.salary)
            {
                return 1;
            }
            else if(this.salary < other.salary) {
                return -1;
            }
            else
            {
                return 0;
            }
            
         }
        public override string ToString()
        {
            return $"Id={id} name={name} salary={salary}";
        }
    }

    public class EmpInfo
    {
        private Emp[] emp;
        public EmpInfo(){
            emp = new Emp[3];
            emp[0]= new Emp(101, "Akshay", 20000.0);
            emp[1] = new Emp(102, "Vijay", 40000.0);
            emp[2] = new Emp(103, "Jay", 50000.0);

                }
        public IEnumerator GetEnumerator()
        {
            return emp.GetEnumerator(); 
        }
    }
}
