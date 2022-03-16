using System;

namespace GameOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Game fortnite = new Game();

            

            //setting up the game
            fortnite.Weapons = new string[] { "sword", "pen", "sniper" };
            fortnite.TotalLootAvailable = 5000000;
            fortnite.TotalPlayers = 200000;
            fortnite.Name = "fortnite";
            fortnite.Kills = 0;

            Console.WriteLine(fortnite.ToString());

            //actions happening in the game
            fortnite.TakeLoot(10);
            fortnite.TakeWeapon("pen");
            fortnite.Kill();

            //display the game progress/ changes
            Console.WriteLine("Available weapons");
            fortnite.ShowAllAvailableWeapons();

            string[] weapon2 = new string[] { "Swords", "Javelin" };
            Game ff7 = new Game("Final Fantasy 7", 100, 200, 0, weapon2);
        }
    }
}
