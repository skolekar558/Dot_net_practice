using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class ProductDetails
    {
        static void Main(string[] args)
        {
            //property initializer
            Product p1=new Product();
            p1.Code = 101;
            p1.Name= "mouse";
            p1.Price = 1000;
            Console.WriteLine($"{p1.Code} {p1.Name} {p1.Price}");
        }
    }
}
