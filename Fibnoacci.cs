using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Fibnoacci
    {
        static void Main(string[] args)
        {
            int count = 10;
            int n1 = 0, n2 = 1;
            
            for(int i=1;i<=count;++i)
            {
                Console.WriteLine(n1);
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
                
        }
    }
}
