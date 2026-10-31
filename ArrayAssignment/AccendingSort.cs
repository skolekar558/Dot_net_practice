using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class AccendingSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 9, 1, 7 };

            // Sorting the array in ascending order
            Array.Sort(arr);

            // Displaying the sorted array
            Console.WriteLine("Sorted Array (Ascending Order):");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
