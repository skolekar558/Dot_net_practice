using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class NameEx
    {
        static void Main(string[] args)
        {
            try
            {
               
                NameException n1 = new NameException(null);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
               
                NameException n2 = new NameException(""); 
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

           
            NameException n3 = new NameException("Priya sharma");
            Console.WriteLine("Person created with name: " + n3.Name);
        }
    }
}
