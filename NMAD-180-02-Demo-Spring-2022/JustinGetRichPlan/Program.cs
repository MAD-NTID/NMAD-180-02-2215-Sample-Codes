using System;

namespace JustinGetRichPlan
{
    /**
     * Author: Kemoy Campbell NMAD 180 - 02
     * Description: Justin's plan to get rich fast
     * Caveat: Only get $$$$ if sell 10k or more and sadly it is only 7% of total sales
     * 
     */


    class Program
    {
        static void Main(string[] args)
        {
            const double COMMISSION_RATE = 0.07;
            const double MINIMUM_COMMISSION = 10000;


            //Use Environment.Exit to quit the program 

            //Console.WriteLine("Invalid input.. Exiting the program...");
            //Environment.Exit(0);

            //example of using char Y / N

            //Console.WriteLine("Did you sell more than $1000 this month? (Y/N): ");
            //char response = char.Parse(Console.ReadLine());

            //if(response == 'Y' || response == 'y')
            //{
            //    Console.Write("How much did you help sell that car for? ");
            //    double userInput = double.Parse(Console.ReadLine());
            //    double profit = userInput * COMMISSION_RATE;
            //    Console.WriteLine($"Justin made {profit:C} commission.");
            //} else
            //{
            //    Console.WriteLine("Better luck next time Justin!");
            //}


            Console.Write("How much did you help sell that car for? ");
            double userInput = double.Parse(Console.ReadLine());

            if (userInput < MINIMUM_COMMISSION)
            {
                Console.WriteLine("Better luck next time Justin!");
            }
            else
            {
                double profit = userInput * COMMISSION_RATE;
                Console.WriteLine($"Justin made {profit:C} commission.");
            }
        }
    }
}
