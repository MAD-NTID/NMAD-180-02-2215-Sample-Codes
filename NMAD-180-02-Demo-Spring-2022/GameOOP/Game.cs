using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOOP
{
    class Game
    {
        private int totalPlayer;

        public string Name { get; set; }
        public int TotalPlayers { 
            get
            {
                return totalPlayer;
            }
            set
            {
                if (value >= 0)
                    totalPlayer = value;
            } 
        }
        public int TotalLootAvailable { get; set; }

        public int Kills { get; set; }

        public string[] Weapons { get; set; }

        //default constructor
        public Game()
        {

        }

        public Game(string name, int totalPlayers,int totalLoot, int kills, string[] weapons)
        {
            Name = name;
            TotalPlayers = totalPlayer;
            TotalLootAvailable = totalLoot;
            Kills = kills;
            Weapons = weapons;
        }

        public int TotalKills()
        {
            return 150;
        }

        public int TotalPlayerAlive()
        {
            return TotalPlayers - Kills;
        }

        public int TakeLoot(int amount)
        {
            TotalLootAvailable -= amount;
            return amount;
        }

        public string TakeWeapon(string weapon)
        {
            for(int i = 0; i< Weapons.Length; i++)
            {
                if (Weapons[i] == weapon)
                    Weapons[i] = "";
            }
            return weapon;
        }

        public void Kill()
        {
            Kills += 1;
        }

        public void ShowAllAvailableWeapons()
        {
            for (int i = 0; i < Weapons.Length; i++)
                if (Weapons[i] != "")
                    Console.WriteLine(Weapons[i]);
        }

        public override string ToString()
        {
            return $"Name: {Name} \nPlayers:{TotalPlayers}\nAvailable loot:{TotalLootAvailable}";
        }
    }
}
