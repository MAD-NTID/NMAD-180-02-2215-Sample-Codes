using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MINIMUM_HEIGHT = 10;
            const int MINIMUM_AGE = 15;

            Console.WriteLine("Insane crazy ride!!");
            Console.Write("How old are you: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("How tall are you: ");
            int height = int.Parse(Console.ReadLine());





            if(age >= MINIMUM_AGE || height >= MINIMUM_HEIGHT)
            {
                Console.WriteLine("Enjoy the ride.... May you survive!");
            } else
            {
                Console.WriteLine("Sorry buddy... come back next year!");
            }


            
            const string USERNAME = "super";
            const string PASSWORD = "passy";
            const int DUO = 12354;

            // one line if statement example
            Console.Write("Enter your username:");
            string username = Console.ReadLine();

            Console.Write("Enter your password:");
            string password = Console.ReadLine();

            Console.Write("Enter duo code:");
            int duo = int.Parse(Console.ReadLine());

            if (username == USERNAME && password == PASSWORD && duo == DUO)
                Console.WriteLine("Welcome master!");
            else
                Console.WriteLine("Invalid creds!");

            //nested if statemet example
            Console.Write("Enter your username:");
            username = Console.ReadLine();

            Console.Write("Enter your password:");
            password = Console.ReadLine();

            Console.Write("Enter duo code:");
            duo = int.Parse(Console.ReadLine());
            if (username == USERNAME)
                if (password == PASSWORD)
                    if (duo == DUO)
                        Console.WriteLine("Welcome master!");
                    else
                        Console.WriteLine("Incorrect duo code");
                else
                    Console.WriteLine("Incorrect password");
            else
                Console.WriteLine("Incorrect username");
        }
    }
}
