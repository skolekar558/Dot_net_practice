using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class AvegArray
    {
        public static int Average(int[] array)
        {
            if(array.Length== 0)
            { 
                return 0;
            }
            int sum = 0;
            foreach( int num in array ) {
            sum += num;
            }
            return sum/array.Length;
        } 
        public static double Average(double[] array)
        {
            if(array.Length== 0)
            {
                return 0.0;
            }
            double sum = 0;
            foreach( double num in array )
            {
                sum += num;
            }
            return sum/ array.Length;
        }
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30, 40, 50 };
            double[] doubleArray = { 10.5, 20.5, 30.5, 40.5, 50.5 };

            int intAverage = Average(intArray);
            double doubleAverage = Average(doubleArray);

            Console.WriteLine("Average of integer array: " + intAverage);
            Console.WriteLine("Average of double array: " + doubleAverage);
        }
    }
}
