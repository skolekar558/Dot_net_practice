using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.StringAssignment
{
    internal class RevString
    {
        static void Main(string[] args)
        {
            string str = "shivam";
            char[] chars = str.ToCharArray();   
            for(int i=str.Length - 1; i >= 0; i--) {
                Console.Write(chars[i]);
            }

        }
    }
}
