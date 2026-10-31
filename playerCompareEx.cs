using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class playerCompareEx
    {
        static void Main(string[] args)
        {

            player virat = new player("Virat", 3500);
            player rohit = new player("Rohit", 3500);

            PlayerCompare obj = new PlayerCompare();

            int result = obj.Compare(virat, rohit);
            if (result == 1)
            {
                Console.WriteLine("Virat has more runs than rohit");
            }
            else if (result == -1)
            {
                Console.WriteLine("virat has less runs than rohit");
            }
            else
            {
                Console.WriteLine("both have equal runs");
            }

        }
    }
}
