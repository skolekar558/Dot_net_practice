using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class player
    {
        private string name;
        private int runs;
        public player(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }
        public int Runs
        {
            get { return runs; }
        }

        public override string ToString() { 
            return $"name={name},runs={runs}";
        }

    }

    public class Team : IEnumerable
    {
        private player[]players;
        public Team()
        {
            players = new player[3];
            players[0] = new player("virat", 30000);
            players[1] = new player("Rohit", 6000);
            players[2] = new player("Dhoni", 600000);
        }
         public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
}
