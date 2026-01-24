using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6.	Use above Employee class, make a constant field as PT(professional tax) as 200. Deduct the PT from salary & display the gross salary.*/
namespace MyWorkspace.Class_object
{
    public class Emp
    {
        private const double PT = 200;

        // Fields
        private int id;
        private string name;
        private double basicSalary;
        private double HRA;
        private double TA;
        private double PF;

        // Constructor
        public Emp(string name, double basicSalary)
        {
          
            this.name = name;
            this.basicSalary = basicSalary;
            // Calculate HRA, TA, and PF
            this.HRA = 0.4 * basicSalary;
            this.TA = 0.2 * basicSalary;
            this.PF = 0.12 * basicSalary;
        }

        // Method to calculate gross salary
        public double CalculateGrossSalary()
        {
            double grossSalary = basicSalary + HRA + TA - PF;
            // Deduct Professional Tax
            grossSalary -= PT;
            return grossSalary;
        }
        // Override ToString() method to display employee details
        public override string ToString()
        {
            return $"Employee ID: {id}\nName: {name}\nBasic Salary: {basicSalary}\nHRA: {HRA}\nTA: {TA}\nPF: {PF}\nGross Salary: {CalculateGrossSalary()}";
        }

    }
}
