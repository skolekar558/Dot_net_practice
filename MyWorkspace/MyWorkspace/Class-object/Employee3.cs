using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF. Accept the value of id, name & basic salary from constructor. Calculate the employee gross salary  & display employee details using ToString() method
a.	HRA- 40% of basic salary
b.	TA – 20% of basic salary
c.	PF -12 % of basic salary
*/
namespace MyWorkspace.Class_object
{
    public class Employee3
    {
        private static int nextId = 1;
        private int id;
        private String name;
        private double bsa;
        double hra;
        double ta;
        double pf;
        double gross;
        public Employee3(int id, string name, double bsa)
        {
            this.id = nextId++;
            this.id = id;
            this.name = name;
            this.bsa = bsa;
            this.hra = 0.4 * bsa;
            this.ta = 0.2 * bsa;
            this.pf = 0.12 * bsa;
            
        }
        public double calculatesal()
        {
            return bsa + ta + hra - pf;
        }
        public override string ToString()
        {
            return $"Employee ID: {id}\nName: {name}\nBasic Salary: {bsa}\nHRA: {hra}\nTA: {ta}\nPF: {pf}\nGross Salary: {calculatesal()}";
        }
        // Static method to display total object count
        public static void DisplayTotalCount()
        {
            Console.WriteLine($"Total Employee Objects: {nextId - 1}");
        }
    }
}
