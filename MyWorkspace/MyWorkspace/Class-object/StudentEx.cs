using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.Class_object
{
    public class StudentEx
    {
        static void Main(string[] args)
        {
            Student s1 = new Student
            {
                Id = 1,
                Name = "PRIYA",
                Per = 78
            };
            Console.WriteLine(s1.ToString());


        }
    }
}
