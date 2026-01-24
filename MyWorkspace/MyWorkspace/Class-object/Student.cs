using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.Class_object
{
    public class Student
    {
        private int roll_no;
        private string name;
        private double per;





        public int Id
        {
            get { return roll_no; }
            set { roll_no = value; }
        } 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Per
        {
            get { return per; } 
            set { per = value; }
        }
        public override string ToString()
        {
            return $"RollNo={roll_no} Name={name} Percentage={per}%";
        }
    }
}