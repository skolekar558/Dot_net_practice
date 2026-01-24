using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkspace.C_Basic
{
    //* Console Class Methods
    //* All methods in pascal case.
    public class ConsoleClass
    {
        static void Main(string[] args)
        {
            //Line by Lineprinting Using WriteLine()method
            System.Console.WriteLine("Welcome");
            System.Console.WriteLine("To");
            System.Console.WriteLine("Programming");

            //Side by Side printing Using Write()method
            System.Console.Write("Welcome ");
            System.Console.Write(" To");
            System.Console.Write(" programming");

            //Wait for pressing some key on the keyboard
            System.Console.ReadKey();

            //Clear the screen
            System.Console.Clear();

        }
    }
}
