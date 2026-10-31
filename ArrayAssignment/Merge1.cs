using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class Merge1
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 4, 5, 6, 7, 8 };

            // Merge arrays and remove duplicates
            int[] mergedArray = arr1.Concat(arr2).Distinct().ToArray();

            // Display merged array
            Console.WriteLine("Merged Array:");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}
