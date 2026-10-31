using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class CalculateExtend
    {
        static void Main(string[] args)
        {
            Calculate calculator= new Calculate();
            Console.WriteLine("1.Rectangle");
            Console.WriteLine("2.Triangle");
            Console.WriteLine("3.Circle");
            Console.WriteLine("4.Square");
            Console.WriteLine("Enter your choice:");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter length of rectangle:");
                    double length=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter width of rectangle:");
                    double breadth=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of Rectangle:" + calculator.CalculateArea(length, breadth));
                    break;

                    case 2:
                    Console.WriteLine("Enter width of triangle:");
                    double width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the height:");
                    int height=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of triangle:"+calculator.CalculateArea(width,height));
                    break;

                    case 3:
                    Console.WriteLine("Enter the radius:");
                    double radius=Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of circle:" + calculator.CalculateArea(radius));
                    break;

                    case 4:
                    Console.WriteLine("Enter side of square:");
                    int side=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of square:"+calculator.CalculateArea(side));
                    break;
                default:
                    Console.WriteLine("Invalid Choice:");
                    break;



            }
        }
    }
}
