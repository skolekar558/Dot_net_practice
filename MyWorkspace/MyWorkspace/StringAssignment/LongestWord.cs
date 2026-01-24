using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyWorkspace.StringAssignment
{
    public class LongestWord
    {
        static void Main(string[] args)
        {
            string str = "This is c# world !";
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
           int Count= 0;
            foreach (string s in words)
            {
                if(s.Length > Count) {
                    word = s;
                    Count=s.Length;
                }
            }
            Console.WriteLine(word);
        }
    }
}
