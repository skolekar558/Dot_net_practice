using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.Class_object
{
    public class EmployeeMain
    {
        static void main(string[] args)
        {
            Employee3 emp1 = new Employee3(101, "Aman", 5600);
            
            Employee3 emp2 = new Employee3(102,"Jane Smith", 60000);
            Employee3 emp3 = new Employee3(103,"Alice Johnson", 55000);

            // Printing details of each employee
            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp2.ToString());
            Console.WriteLine(emp3.ToString());

            // Displaying total object count
            Employee3.DisplayTotalCount();

        }
    }
}
