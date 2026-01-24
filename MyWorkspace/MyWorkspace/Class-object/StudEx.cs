using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.Class_object
{
    public class StudEx
    {
        static void Main(string[] args)
        {
            // Creating a Student object
            Stud student = new Stud(101, "John Doe", 85, 90, 75);

            // Printing student details
            Console.WriteLine(student.ToString());
        }
    }
}
