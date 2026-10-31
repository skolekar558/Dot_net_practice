using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Playerex
    {
        static void Main(string[] args)
        {
                Team ind= new Team();
            foreach(player p in ind)
            {
                Console.WriteLine(p);
            }
        }
    }
}
