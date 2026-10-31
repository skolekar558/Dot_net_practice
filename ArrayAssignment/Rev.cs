using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class Rev
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };

            // Reversing the array
            ReverseArray(arr);

            // Displaying the reversed array
            Console.WriteLine("Reversed Array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                // Swap elements at start and end indices
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                // Move start and end pointers towards the middle
                start++;
                end--;
            }
        }
    }
}
