using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class MaxMin
    {
        static void Main(string[] args)
        {
            // Define an array
            int[] array = { 3, 7, 2, 9, 4, 1, 8, 6, 5 };

            // Initialize variables to store maximum and minimum values
            int max = array[0];
            int min = array[0];

            // Iterate through the array to find maximum and minimum values
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }
            }

            // Display the maximum and minimum values
            Console.WriteLine("Maximum value in the array: " + max);
            Console.WriteLine("Minimum value in the array: " + min);
        }
    }
}
