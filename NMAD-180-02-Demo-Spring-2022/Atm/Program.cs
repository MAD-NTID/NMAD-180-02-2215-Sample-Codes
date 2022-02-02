using System;

namespace Atm
{
    class Program
    {
        static void Main(string[] args)
        {

            const int OPTION_ONE = 1;
            const int OPTION_TWO = 2;
            const int OPTION_THREE = 3;
            const int OPTION_FOUR = 4;
            const int OPTION_FIVE = 5;
            const int OPTION_SIX = 6;
            int option;


            /*---------------------------------
             *    USING IF EXAMPLE             |
             * --------------------------------*/
            Console.Title = "Cool ATM";
            Console.WriteLine("1. Fash Cash");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Balance Inquiry");
            Console.WriteLine("4. Deposit");
            Console.WriteLine("5. Transfer");
            Console.WriteLine("6. Exit");

            Console.Write("Option:");

            //did the user enter a int? if not we will inform them of the error and quit
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("You are only allow to enter an integer");
                Environment.Exit(0);
            }

            //there is no need to do this with switch because the default in switch will take care of it
            //we need to validate that the user enter the option 1-6
            if (option < OPTION_ONE || option > OPTION_SIX)
            {
                Console.WriteLine("Invalid selection, please select 1-6");
                Environment.Exit(0);
            }

            if (option == OPTION_ONE)
            {
                Console.WriteLine("Fast cash code goes here");
            }
            else if (option == OPTION_TWO)
            {
                Console.WriteLine("Withdraw some cash");
            }
            else if (option == OPTION_THREE)
            {
                Console.WriteLine("show current balance amount");
            }
            else if (option == OPTION_FOUR)
            {
                Console.WriteLine("some money in the bank");
            }
            else if (option == OPTION_FIVE)
            {
                Console.WriteLine("The balance goes down");
            }
            else
            {
                Console.WriteLine("Thank you for using cool atm");
                Environment.Exit(0);
            }


            /*---------------------------------
             *    USING SWITCH EXAMPLE         |
             * --------------------------------*/

            Console.Title = "Cool ATM";
            Console.WriteLine("1. Fash Cash");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Balance Inquiry");
            Console.WriteLine("4. Deposit");
            Console.WriteLine("5. Transfer");
            Console.WriteLine("6. Exit");

            Console.Write("Option:");

            //did the user enter a int? if not we will inform them of the error and quit
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("You are only allow to enter an integer");
                Environment.Exit(0);
            }


            switch (option)
            {
                case OPTION_ONE:
                    Console.WriteLine("Fast cash code goes here");
                    break;

                case OPTION_TWO:
                    Console.WriteLine("Withdraw some cash");
                    break;
                case OPTION_THREE:
                    Console.WriteLine("show current balance amount");
                    break;
                case OPTION_FOUR:
                    Console.WriteLine("some money in the bank");
                    break;
                case OPTION_FIVE:
                    Console.WriteLine("The total goes down");
                    break;
                case OPTION_SIX:
                    Console.WriteLine("Thank you for using cool atm");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection, please select 1-6");
                    break;
            }

        }
    }
}
