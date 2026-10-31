using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.wap to create student class student contain id,name,three subject marks
create method 1 to accept student details
2 method to calculate percentage for 3 subject marks
3 method to display all student details including percentage*/
namespace MyFirstApp
{
    public class Student1
    {
        public int Id;
        public string Name;
        public int Sub1;
        public int Sub2;
        public int Sub3;
        public int Total;
        public double Percentage;

        public void Accept(int id, string name, int sub1, int sub2, int sub3)
        {
            Id = id;
            Name = name;
            Sub1 = sub1;
            Sub2 = sub2;
            Sub3 = sub3;
        }

        public void CalculatePercentage()
        {
            Total = Sub1 + Sub2 + Sub3;
            Percentage = (Total / 300.0) * 100; // Ensure at least one operand is double to get accurate percentage
        }

        public string Display()
        {
            return $"Student ID: {Id}, Name: {Name}, Subject 1: {Sub1}, Subject 2: {Sub2}, Subject 3: {Sub3}, Total: {Total}, Percentage: {Percentage}%";
        }
    }    }
