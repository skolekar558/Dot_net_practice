using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class DuplicateEle
    {
        static void Main(string[] args)
        {
            // Define an array with duplicate elements
            int[] array = { 3, 7, 2, 9, 4, 7, 8, 6, 5, 3, 9, 4 };

            // Create a dictionary to store element counts
            Dictionary<int, int> elementCounts = new Dictionary<int, int>();

            // Count occurrences of each element
            foreach (int num in array)
            {
                if (elementCounts.ContainsKey(num))
                {
                    elementCounts[num]++;
                }
                else
                {
                    elementCounts[num] = 1;
                }
            }

            // Count total number of duplicate elements
            int totalDuplicates = 0;
            foreach (int count in elementCounts.Values)
            {
                if (count > 1)
                {
                    totalDuplicates += count - 1;
                }
            }

            // Display total number of duplicate elements
            Console.WriteLine("Total number of duplicate elements in the array: " + totalDuplicates);
        }
    }
}
