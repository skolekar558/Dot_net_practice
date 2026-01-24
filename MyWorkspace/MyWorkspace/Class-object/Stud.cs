using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7.	Create Student class with roll no, name, accept 3 subjects marks from constructor. Calculate the total marks & percentage. Display student details using ToString()*/
namespace MyWorkspace.Class_object
{
    public class Stud
    {
        private int rollNo;
        private string name;
        private int s1;
        private int s2;
        private int s3;

        // Constructor
        public Stud(int rollNo, string name, int s1, int s2, int s3)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.s1 = s1;
            this.s2 = s2;
            this.s3= s3;
        }

        // Method to calculate total marks
        public int CalculateTotalMarks()
        {
            return s1 + s2 + s3;
        }

        // Method to calculate percentage
        public double CalculatePercentage()
        {
            int totalMarks = CalculateTotalMarks();
            return (totalMarks / 3.0) * 100;
        }

        // Override ToString() method to display student details
        public override string ToString()
        {
            return $"Roll No: {rollNo}\nName: {name}\nSubject 1 Marks: {s1}\nSubject 2 Marks: {s2}\nSubject 3 Marks: {s3}\nTotal Marks: {CalculateTotalMarks()}\nPercentage: {CalculatePercentage()}%";
        }
    }
}
