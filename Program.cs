// See https://aka.ms/new-console-template for more information
//Primitive data types
namespace MyFirstApp
{
    public class Program
    {
       public static void Main(string[] args)
        {
            // Variable declarations
            short s = 100;
            int no = 10;
            long l = 45556766;
            float f1 = 20.33F;
            double d1 = 45.55;
            decimal d = 47.55M;

            // Outputting a simple string
            Console.WriteLine("Hello, World!");

            // Outputting variables using string concatenation
            Console.WriteLine("integer no is: " + no + " and decimal no is: " + d);

            // Outputting variables using placeholder syntax
            Console.WriteLine("integer no is {0} and float value is {1}", no, f1);

            // Outputting variables using string interpolation
            Console.WriteLine($"integer no is {no} and float value is {f1}");
        }
    }
}