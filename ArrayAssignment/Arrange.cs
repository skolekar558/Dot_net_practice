using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class Arrange
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, -3, -19, 29, -5, -61, 44, 7, -9 };

            // Arrange the elements where all negative integers appear before all positive integers
            RearrangeArray(arr);

            // Display rearranged array
            Console.WriteLine("Rearranged Array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        static void RearrangeArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                // Find the first positive integer from the left
                while (left <= right && arr[left] < 0)
                {
                    left++;
                }

                // Find the first negative integer from the right
                while (left <= right && arr[right] >= 0)
                {
                    right--;
                }

                // Swap elements if left pointer is before right pointer
                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
        }
    }
}
