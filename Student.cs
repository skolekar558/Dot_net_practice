using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Student
    {
        private int rollno;
        private string name;
        //constructor which assign default value to members
        private Student()
        {
            rollno = 1;
            name = "Suraj";
        }
        //constructor with parameters
        public Student(int rollno,string name)
        {
            this.rollno = rollno;//this refers to data members
            this.name = name;
        }
        public string Display()
        {
            return $"Rollno={rollno},name={name}";
        }
    }
}
