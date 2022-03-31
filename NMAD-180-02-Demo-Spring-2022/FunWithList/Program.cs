using System;
using System.Collections.Generic;

namespace FunWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<string> friends = new List<string>();

            friends.Add("Amir");
            friends.Add("Marisa");
            friends.Add("Erik");

            Console.WriteLine($"My friends list size is:{friends.Count}");


            //show all friends using foreach
            Console.WriteLine($"My friends are:");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }


            //show friends using for loop
            Console.WriteLine();
            for (int i = 0; i< friends.Count; i++)
            {
                Console.WriteLine(friends[i]);
            }

            //friends.Remove("Amir");
            friends.RemoveAt(0);
            Console.WriteLine();
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            //Console.WriteLine($"My friends are:{friends.List}");

            Dictionary<string, double> gpas = new Dictionary<string, double>();
            gpas.Add("Erik", 2.6);
            gpas.Add("Marisa", 4.0);
            gpas.Add("Amir", 0);

            Console.WriteLine(gpas["Marisa"]);

            //blows up if access when key not in the dictionary
            //Console.WriteLine(gpas["foo"]);

            //use try get value for protection
            if(!gpas.TryGetValue("foo", out double answer))
                Console.WriteLine("The key foo was not found");
            else
                Console.WriteLine(gpas["foo"]);

            Console.WriteLine();
            foreach(KeyValuePair<string, double> item in gpas)
            {
                Console.WriteLine($"{item.Key}'s GPA is: {item.Value}");
            }

        }
    }
}
