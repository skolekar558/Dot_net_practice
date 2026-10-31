using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public  class Stud1
    {
        static void Main(string[] args)
        {
            Student1 student = new Student1();
            Console.WriteLine("Enter Student Details:");
            Console.Write("ID: ");
            int id =Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Subject 1 Marks: ");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Subject 2 Marks: ");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Subject 3 Marks: ");
            int sub3 = Convert.ToInt32(Console.ReadLine());

            student.Accept(id, name, sub1, sub2, sub3);
            student.CalculatePercentage();
            Console.WriteLine(student.Display());
        }
    }
}
