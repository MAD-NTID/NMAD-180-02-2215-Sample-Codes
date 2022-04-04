using System; 

namespace TheKing3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Top of the world!!!");
            Console.WriteLine("Humans, bow down!!!");
            SocialMedia media = new SocialMedia();

            while (true)
            {
                Console.WriteLine("Menu\n========");
                Console.WriteLine("1. Add a new friend\n2. Remove a friend\n3.Show all friends for a specific person\n4.Spill da bean");
                Console.Write("What do you want to do:");
                int option = int.Parse(Console.ReadLine());

                if(option == 1)
                {
                    Console.Write("Key:");
                    string key = Console.ReadLine();

                    Console.Write("Name:");
                    string name = Console.ReadLine();

                    Console.Write("Age:");
                    int age = int.Parse(Console.ReadLine());

                    string dateAdded = DateTime.Now.ToString();
                    Friend friend = new Friend(name, age, dateAdded);
                    if (media.AddFriend(key, friend))
                    {
                        Console.WriteLine("Your new friend was added");
                    }
                } else if(option==2)
                {
                    Console.Write("Who do you want to remove a friend for?");
                    string key = Console.ReadLine();

                    Console.Write("What is the name of the friend to remove:");
                    string name = Console.ReadLine();
                    if(media.RemoveFriend(key, name))
                    {
                        Console.WriteLine("Be gone!!!");
                    }
                } else if(option==3)
                {
                    Console.Write("Who do you want to show friends for?");
                    string key = Console.ReadLine();
                    media.ShowAllFriend(key);
                } else
                {
                    media.showAllFriendsInTheNetwork();
                }
            }

            




        }
    }
}
