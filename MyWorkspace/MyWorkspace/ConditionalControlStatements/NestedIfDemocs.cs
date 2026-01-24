using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.ConditionalStatements
{
    public class NestedIfDemocs
    {
        static void Main(string[] args)
        {
            int Marks = 67;
            char gradeletter;
            if (Marks >= 35)
            {
                if(Marks >= 85)
                {
                    gradeletter= 'O';
                }
                else if(Marks >=65 && Marks < 85)
                {
                    gradeletter='A';
                }
                else if(Marks>=45 && Marks < 65)
                {
                    gradeletter = 'B';
                }
                else
                {
                    gradeletter = 'C';
                }
                
            }
            else
            {
                gradeletter = 'F';
            }
            Console.WriteLine(gradeletter);
        }
    }
}
