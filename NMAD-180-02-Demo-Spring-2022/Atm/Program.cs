using System;

namespace Atm
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.Title = "Cool ATM";
            Console.WriteLine("1. Fash Cash");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Balance Inquiry");
            Console.WriteLine("4. Deposit");
            Console.WriteLine("5. Transfer");
            Console.WriteLine("6. Exit");

            Console.Write("Option:");
            string option = Console.ReadLine();
    

            switch (option)
            {
                case "1":
                    Console.WriteLine("Fast cash code goes here");
                    break;

                case "2":
                    Console.WriteLine("Withdraw some cash");
                    break;
                case "3":
                    Console.WriteLine("show current balance amount");
                    break;
                case "4":
                    Console.WriteLine("some money in the bank");
                    break;
                case "5":
                    Console.WriteLine("The total goes down");
                    break;
                case "6":
                    Console.WriteLine("Thank you for using cool atm");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection!!!");
                    break;
            }

            //check to ensure the user enter a number
            //if(int.TryParse(Console.ReadLine(), out int option))
            //{

            //} else
            //{
            //    Console.WriteLine("Please enter number!!!");
            //    Environment.Exit(0);
            //}






            //use to show console title
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
