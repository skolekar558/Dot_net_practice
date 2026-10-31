using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class PlayerCompare : IComparer<player>

    {
        public int Compare(player? x, player? y)
        {
            if (x.Runs > y.Runs)
            {
                return 1;
            }
            else if (x.Runs < y.Runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
