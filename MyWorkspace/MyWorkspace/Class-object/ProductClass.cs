using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	Create class Product. Add fields like id, name and price. Create properties for each field. Use object initializer syntax initialize the object. Print product details using ToString()*/
namespace MyWorkspace.Class_object
{
    public class ProductClass
    {
        public int id;
        public string name;
        public double price;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
      public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public void ApplyDiscount(double discountPercentage)
        {
            double discountAmount = price * (discountPercentage / 100);
            double discountedPrice = price - discountAmount;

            Console.WriteLine($"Actual Price: {price:C}");
            Console.WriteLine($"Discounted Price ({discountPercentage}% off): {discountedPrice:C}");
        }
        public override string ToString()
        {
            return $"Product ID: {id}\nName: {name}\nPrice: {price}";
        }
    }
}
