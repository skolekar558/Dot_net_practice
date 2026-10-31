using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class BookDetails
    {
        static void Main(string[] args)
        {
            Book b1= new Book();
            b1.bid = 101;
            b1.title = "wings of fire";
            b1.price = 10000;
            Console.WriteLine($"{b1.bid} {b1.title} {b1.price}");
            Book b2= new Book { bid = 102,title="mindful",price=599 };
            Console.WriteLine($"{b2.bid} {b2.title} {b2.price}");

        }
    }
}
