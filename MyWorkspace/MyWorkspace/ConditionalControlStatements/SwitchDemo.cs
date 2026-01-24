using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.ConditionalStatements
{
    public class SwitchDemo
    {
        static void Main(string[] args)
        {
            char gradeLetter= 'A';
            string gradeDesc;
            switch(gradeLetter)
            {
                case 'O':Console.WriteLine("Outstanding");break;
                case 'A': Console.WriteLine("Execellent"); break;
                case 'B': Console.WriteLine("Good"); break;
                case 'C': Console.WriteLine("Average"); break;
                case 'F': Console.WriteLine("Fail"); break;
                default : Console.WriteLine("none");break;

            }
        }
    }
}
