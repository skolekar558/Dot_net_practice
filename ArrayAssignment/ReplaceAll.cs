using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class ReplaceAll
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            // Replace negative values with square of immediate left element
            ReplaceNegatives(arr);

            // Display modified array
            Console.WriteLine("Modified Array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        static void ReplaceNegatives(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    // If current element is negative, replace it with square of its immediate left element
                    if (i > 0)
                    {
                        arr[i] = arr[i - 1] * arr[i - 1];
                    }
                    else
                    {
                        // If there is no immediate left element, replace it with 0
                        arr[i] = 0;
                    }
                }
            }
        }
    }
}
