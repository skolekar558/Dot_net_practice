using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.StringAssignment
{
    public class Palidrome
    {
        static void Main(string[] args)
        {
            string str = "abba";
            string nstr = "";
            char ch;
            bool isPalidrome=false;
            for(int i = 0; i < str.Length; i++) { 
            ch= str[i];
            nstr=ch+nstr;
            }
            if(nstr.Equals(str) )
            {
                isPalidrome = true;
            }
           if(!isPalidrome )
            {
                Console.WriteLine(str+" not a palidrome");
            }
            else
            {
                Console.Write(str + " is a palidrome");
            }
        }
    }
}
