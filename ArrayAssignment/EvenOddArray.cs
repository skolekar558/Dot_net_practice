using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class EvenOddArray
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Separate even and odd elements into two arrays
            int[] evenArray = new int[originalArray.Length];
            int[] oddArray = new int[originalArray.Length];
            int evenCount = 0, oddCount = 0;

            foreach (var num in originalArray)
            {
                if (num % 2 == 0)
                {
                    evenArray[evenCount] = num;
                    evenCount++;
                }
                else
                {
                    oddArray[oddCount] = num;
                    oddCount++;
                }
            }

            // Truncate the arrays to remove unused spaces
            Array.Resize(ref evenArray, evenCount);
            Array.Resize(ref oddArray, oddCount);

            // Display even and odd arrays
            Console.WriteLine("Even numbers:");
            foreach (var num in evenArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nOdd numbers:");
            foreach (var num in oddArray)
            {
                Console.Write(num + " ");
            }
        }
    }

    
}
