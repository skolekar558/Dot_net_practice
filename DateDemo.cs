using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class DateDemo
    {
        private int day;
        private int month;
        private int year;

        public DateDemo()
        {
            day = 12;
            month = 11;
            year = 2024;
        }
        // Constructor
        public DateDemo(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public String Display()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
