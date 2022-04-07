using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Game
    {
        private int round;
        public int Round { get => round; }
        public List<Player> players;

        public Game(List<Player> _players)
        {
            players = _players;
        }

        public void Play()
        {
            round += 1;
            Console.WriteLine($"Round:{round}\n");

            foreach(Player player in players)
            {
                player.Hand.Show();
                Console.WriteLine(player.Hand.Selected);
            }

            Player winner = Winner(players[0], players[1]);
            if(winner == null)
            {
                players[1].Wins += 1;
                players[0].Wins += 1;
            } else
            {
                winner.Wins += 1;
            }

            ShowGameRecord();
        }

        public void ShowGameRecord()
        {
            foreach(Player player in players)
            {
                Console.WriteLine(player.ToString());
            }
        }

        public Player Winner(Player player1, Player player2)
        {

            //let us say player 1 select a rock
            if(player1.Hand.Selected == Hand.Shapes.Rock)
            {
                if (player2.Hand.Selected == Hand.Shapes.Scissor)
                    return player1;
                if (player2.Hand.Selected == Hand.Shapes.Paper)
                    return player2;
            }

            else if (player1.Hand.Selected == Hand.Shapes.Scissor)
            {
                if (player2.Hand.Selected == Hand.Shapes.Rock)
                    return player2;
                if (player2.Hand.Selected == Hand.Shapes.Paper)
                    return player1;
            }

            else if (player1.Hand.Selected == Hand.Shapes.Paper)
            {
                if (player2.Hand.Selected == Hand.Shapes.Rock)
                    return player1;
                if (player2.Hand.Selected == Hand.Shapes.Scissor)
                    return player2;
            }

            //TIE
            return null;

        }

    }
}
