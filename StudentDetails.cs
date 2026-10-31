using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class StudentDetails
    {
        static void Main(string[] args)
        {
            //Student stud = new Student();--private constructor
            Student s1 = new Student(2, "Akshay");
            //Console.WriteLine(stud.Display());
            Console.WriteLine(s1.Display());

        }
    }
}
