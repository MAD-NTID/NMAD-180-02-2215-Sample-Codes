using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace RockPaperScissor
{
    class Program
    {
        private static Game game;

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1. Play a new game");
                Console.WriteLine("2. Show game history");
                Console.WriteLine("3. Save game");
                Console.WriteLine("4. Continue previous game");
                Console.WriteLine("5. Watch computer vs computer");
                Console.WriteLine("6. Exit");

                Console.Write("Selection:");
                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        NewGameInfo();
                        while(true)
                        {
                            game.Play();
                            Console.Write("Do you want to play again?");
                            string response = Console.ReadLine().ToLower();
                            if(response == "n")
                            {
                                break;
                            }
                        }
                       
                        break;
                    case 2:
                        game.ShowGameRecord();
                        break;
                    case 3:
                        StreamWriter writer = new StreamWriter("game.txt");
                        foreach(Player player in game.players)
                        {
                            writer.WriteLine(player);
                        }
                        writer.Close();
                        break;
                    case 4:
                        StreamReader reader = new StreamReader("game.txt");
                        List<Player> players = new List<Player>();
                        while (!reader.EndOfStream)
                        {
                            string[] info = reader.ReadLine().Split(",");
                            Enum.TryParse(info[1], out Hand.Shapes shape);
                            Hand hand = new Hand(shape);
                            Player player = new Player(info[0], hand, int.Parse(info[2]));
                            players.Add(player);

                        }
                        reader.Close();
                        game = new Game(players);
                        while (true)
                        {
                            game.Play();
                            Console.Write("Do you want to play again?");
                            string response = Console.ReadLine().ToLower();
                            if (response == "n")
                            {
                                break;
                            }
                        }

                        break;
                    case 5:
                        //super advanced(not really)
                        Player player1 = new Player("Computer 1");
                        Player player2 = new Player("Computer 2");
                        game = new Game(new List<Player>() { player1, player2 });
                        while (true)
                        {
                            game.Play();
                            Thread.Sleep(2000);
                        }
                        break;
                    case 6:
                        Console.WriteLine("See ya later...loser!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Seriously man?! select one from the option");
                        break;


                }
            }
        }

        public static void NewGameInfo()
        {
            Console.Write("Enter player 1's name:");
            Player player1 = new Player(Console.ReadLine());
            Console.Write("Enter player 2's name:");
            Player player2 = new Player(Console.ReadLine());

            //List<Player> players = new List<Player>();
            //players.Add(player1);
            //players.Add(player2);

            game = new Game(new List<Player>() { player1, player2 });
        }
    }
}
