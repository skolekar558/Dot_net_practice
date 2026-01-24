using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Height is less than 150 cm = "Dwarf"

Height is between 150 cm and 165 cm = "Average height"

Height is between 165 cm and 195 cm = "Tall"

Height is above 195 cm = "Abnormal height"



Note: 1 inch = 2.54 centimeter

You need to convert the input value (inches) into centimeters.



Eg:

Input: 75

Output: Tall*/
namespace MyWorkspace.LoopingAssignment
{
    public class HeightCategory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height in inches");
            int height=Convert.ToInt32(Console.ReadLine());
            double Height = height * 2.54;
            if(Height < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if(Height >=150 &&  Height <= 165)
            {
                Console.WriteLine("Average height");
            }
            else if(Height>=165 && Height <= 195)
            {
                Console.WriteLine("Tall");
            }
            else if( Height >= 195)
            {
                Console.WriteLine("Abnormal height");
            }
        }
    }
}
