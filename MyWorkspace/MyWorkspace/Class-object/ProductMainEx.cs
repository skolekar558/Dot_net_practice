using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.Class_object
{
    public class ProductMainEx
    {
       
            static void Main(string[] args)
        {
            ProductClass product = new ProductClass
            {
                Id = 1,
                Name = "Microphone",
                Price = 1000.0,
            };
            Console.WriteLine(product.ToString());
            // Applying a discount of 10%
            Console.WriteLine("\nApplying 10% discount:");
            product.ApplyDiscount(10);
        }
    
    }
}
