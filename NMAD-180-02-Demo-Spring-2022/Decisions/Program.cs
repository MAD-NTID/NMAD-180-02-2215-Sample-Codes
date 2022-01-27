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


            //const string USERNAME = "super";
            //const string PASSWORD = "passy";
            //const int DUO = 12354;

            //Console.Write("Enter your username:");
            //string username = Console.ReadLine();

            //Console.Write("Enter your password:");
            //string password = Console.ReadLine();

            //Console.Write("Enter duo code:");
            //int duo = int.Parse(Console.ReadLine());

            //if(username== USERNAME && password==PASSWORD && duo == DUO)
            //    Console.WriteLine("Welcome master!");
            //else
            //    Console.WriteLine("Invalid creds!");

            //if(username == USERNAME)
            //    if(password==PASSWORD)
            //        if(duo==DUO)
            //            Console.WriteLine("Welcome master!");
            //        else
            //            Console.WriteLine("Invalid duo code");
            //    else
            //        Console.WriteLine("You are not allowed here.. nice try!");
            //else
            //    Console.WriteLine("Incorrect username or password");
            
            //const int TOP_SECRET_PIN = 5555;
            //const int TOP_SECRET_PIN2 = 5551;

            //Console.Title = "AWESOME ATM";

            //Console.Write("Enter your pin:");
            //int inputPin = int.Parse(Console.ReadLine());

            //if(inputPin == TOP_SECRET_PIN)
            //    Console.WriteLine("Here is your money, $10000000000");
            //else if(inputPin==TOP_SECRET_PIN2)
            //    Console.WriteLine("Here is your money $100");

            //else
            //    Console.WriteLine("Wrong pin... No money for ya!!");



            ////use to pause the program so we can see the title
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey(true);
        }
    }
}
