using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.Class_object
{
    public class Empex
    {
        static void Main(string[] args)
        {
            // Creating Employee objects
            Emp emp1 = new Emp("John Doe", 50000);
           

            // Printing details of each employee
            Console.WriteLine(emp1.ToString());
            

            
        }
    }
}

