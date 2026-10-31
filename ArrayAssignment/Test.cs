using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class Test
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = { 52, 22, 62, 12, 42, 22 };

            bool areEqual = ArraysAreEqual(arr1, arr2);

            if (areEqual)
            {
                Console.WriteLine("Arrays are equal.");
            }
            else
            {
                Console.WriteLine("Arrays are not equal.");
            }
        }

        static bool ArraysAreEqual(int[] arr1, int[] arr2)
        {
            // If arrays have different lengths, they are not equal
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            // Sort both arrays
            Array.Sort(arr1);
            Array.Sort(arr2);

            // Compare each element of the arrays
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
