using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class EmployeeDetails
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee
            Employee emp = new Employee();

            // Assign predefined values
            emp.Assign();

            // Calculate salary
            emp.CalculateSalary();

            // Display employee details
            Console.WriteLine(emp.Display());

            // Create another instance of Employee
            Employee emp2 = new Employee();

            // Accept custom values
            emp2.Accept(101, "Ajay", 4500.56, 3200.44, 500.50);

            // Calculate salary for emp2
            emp2.CalculateSalary();

            // Display employee details for emp2
            Console.WriteLine(emp2.Display());
        }
    
}
}
