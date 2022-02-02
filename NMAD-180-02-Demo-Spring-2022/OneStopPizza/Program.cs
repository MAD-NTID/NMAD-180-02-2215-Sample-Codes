using System;

namespace OneStopPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            //  GOAL: Use TryParse, String formatting,Logical Operators
            //  and Nested If Statements / Maybe Negation Logical Operator

            //  Create a Pizza program where users can select options for pizza toppings
            //  Each toppings cost .50 cents - up to two toppings
            //  Small pizza is 8 dollars
            //  Medium pizza is 10 dollars
            //  Large pizza is 12 dollars
            //  New York State Tax is 8%
            //  Calculate the total cost including tax

            string smallPizza = "Small Pizza";
            string mediumPizza = "Medium Pizza";
            string largePizza = "Large Pizza";

            const double SMALL_PIZZA = 8.0;
            const double MEDIUM_PIZZA = 10.0;
            const double LARGE_PIZZA = 12.0;

            const double NY_TAX = .08;
            const double TOPPINGS = .50;

            double subtotal = 0;


            Console.WriteLine("Welcome to ONESTOP PIZZA\n================================\n");
            Console.WriteLine($"{"Size",-15}{"Price",15}");
            Console.WriteLine($"1.{smallPizza,-15}{SMALL_PIZZA,15:C}");
            Console.WriteLine($"2.{mediumPizza,-15}{MEDIUM_PIZZA,15:C}");
            Console.WriteLine($"3.{largePizza,-15}{LARGE_PIZZA,15:C}");

            Console.Write("\nselect pizza size:");

            //ensure the user enter a number!
            if(int.TryParse(Console.ReadLine(), out int input))
            {
                switch (input)
                {
                    case 1:
                        subtotal = SMALL_PIZZA;
                        break;
                    case 2:
                        subtotal = MEDIUM_PIZZA;
                        break;
                    case 3:
                        subtotal = LARGE_PIZZA;
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
                
                Console.Write("Do you want pepperoni (Y/N):");
                if(char.TryParse(Console.ReadLine().ToUpper(), out char isPepperoni)){
                    if (isPepperoni == 'Y')
                    {
                        subtotal = subtotal + TOPPINGS;
                    } else if(isPepperoni!='N')
                    {
                        Console.WriteLine("Invalid choice!");
                    }
                } 

                Console.WriteLine($"Subtotal:{subtotal:C}");
                Console.WriteLine($"Tax:{subtotal * NY_TAX:C}");
                Console.WriteLine($"Final total:{(subtotal * NY_TAX) + subtotal:C}");
            } else
            {
                Console.WriteLine("Invalid size selection!");
                Console.WriteLine("Try that stuff somewhere else!");
            }







        }
    }
}
