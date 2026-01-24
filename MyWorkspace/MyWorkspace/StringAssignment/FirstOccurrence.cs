using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.	Write a C# program to find first occurrence of a character in a given string.
namespace MyWorkspace.StringAssignment
{
    public class FirstOccurrence
    {
        static void Main(string[] args)
        {
            String str = "Welcome to .net";
            char c= 'o';
            int index=str.IndexOf(c);
            if(index != -1 )
            {
                Console.WriteLine("First occurrence of character" + c + "is of index:" + index);
            }
            else
            {
                Console.WriteLine("The character" + c + "not found in string");
            }
        }
    }
}
