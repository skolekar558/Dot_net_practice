using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.WAP to split string into 2 tokens where string is “HELLO$WORLD”
namespace MyWorkspace.StringAssignment
{
    public class Split
    {
        static void Main(string[] args)
        {
            String str = "HELLO$WORLD";
            string[]tokens=str.Split('$');
            foreach(string token in tokens)
            {
                Console.WriteLine(token);
            }

        }
    }
}
