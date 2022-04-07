using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Hand
    {
        const int MIN = 0;
        private Shapes selected;
        public Shapes Selected { get => selected; }
        public enum Shapes
        {
            Rock,
            Paper,
            Scissor
        }

        public Hand()
        {

        }

        public Hand(Shapes shape)
        {
            selected = shape;
        }

        public Shapes Show()
        {
            Random random = new Random();
            int max = Enum.GetValues(typeof(Shapes)).Length;

            int pick = random.Next(MIN, max);

            selected =  (Shapes)pick;
            return selected;
        }

        public override string ToString()
        {
            return $"{selected}";

        }

        //public Shapes Rank(Shapes hand1, Shapes hand2)
        //{
        //    if (hand1 == Shapes.Rock && hand2 == Shapes.Scissor)
        //        return hand1;

        //}


    }
}
