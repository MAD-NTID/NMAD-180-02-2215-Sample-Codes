using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Player
    {
        public string Name { get; set; }
        public int Wins { get; set; }

        public Hand Hand { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new Hand(); 
        }

        public Player(string name, Hand hand, int win)
        {
            Name = name;
            Hand = hand;
            Wins = win;
        }

        public override string ToString()
        {
            return $"{Name},{Hand},{Wins}";
        }


    }
}
