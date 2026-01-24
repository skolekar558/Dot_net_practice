using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//3.	Write a C# program to count occurrences of a character in given string.
namespace MyWorkspace.StringAssignment
{
    public class Occurrence_Of_Char
    {
        static void Main(string[] args)
        {
            string str = "welcome to .net";
            char c = 'o';
            int count= coutOccurrence(str, c);
            Console.WriteLine("Count of character 'o'in string="+count);
        }
        static int coutOccurrence(string str, char c)
        {
            int count = 0;
            foreach (char ch in str) {
                if (ch == c) {
                    count++;
                }
                
            }
            return count;
        }
    }
}
