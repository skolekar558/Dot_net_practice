using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyFirstApp
{
    public class Product
    {
        private int code;
        private string name;
        private double price;

        public int Code
        {
            set { code = value; }
            get { return code; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }
    }
