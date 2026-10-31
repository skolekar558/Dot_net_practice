using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 5, 6, 7, 8 };
            int[] b = { 2, 9, 8, 10, 11, 12, 13 };
            int[] c = new int[a.Length + b.Length];

            // Copy elements of array 'a' to 'c'
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }

            // Copy elements of array 'b' to 'c' starting from end of 'a'
            for (int i = 0; i < b.Length; i++)
            {
                c[a.Length + i] = b[i];
            }

            Console.WriteLine("Merged Array:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + ", ");
            }

            Console.WriteLine(); // Just for a new line after the array
        }
    }


}

