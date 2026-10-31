using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.ArrayAssignment
{
    public class FrequencyCount
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 4, 5, 5, 5, 6, 6, 6 };
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Counting frequency of each element
            foreach (int num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            // Displaying frequency of each element
            Console.WriteLine("Element : Frequency");
            foreach (KeyValuePair<int, int> entry in frequencyMap)
            {
                Console.WriteLine(entry.Key + " : " + entry.Value);
            }
        }
    

    }
}
