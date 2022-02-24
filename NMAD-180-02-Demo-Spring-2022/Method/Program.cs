using System;

namespace Method
{
    class Program
    {

        static void Main(string[] args)
        {


            /***********************************************
             * EXAMPLE OF ADDING TWO NUMBERS WITH A METHOD 
             * 
             * *********************************************/

            //we can create variables
            int numberOne = 5;
            int numberTwo = 6;
            int res = AddTwoNumbers(numberTwo, numberOne);
            Console.WriteLine(res);

            Console.WriteLine("\n");


            //we can also pass the number to the variable directly
            Console.WriteLine(AddTwoNumbers(5,6));


            //we can loop through the array and add 5 to each numbers
            int[] numbers = { 1, 2, 3, 4 };

            Console.WriteLine("\n");

            for(int i = 0; i< numbers.Length; i++)
            {
                Console.WriteLine(AddTwoNumbers(numbers[i], 5));
            }


            //Example of using a method to login a user
            Console.WriteLine("Welcome to Space force!!");

            while (true)
            {
                Console.Write("Enter the username:");
                string user = Console.ReadLine();

                Console.WriteLine("Enter the password:");
                string pass = Console.ReadLine();

                if (login(pass, user))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }


            }

            Console.WriteLine("Welcome to space force top secret floor!");

        }

        /**
         * This method takes two numbers, add them and return the result 
         */
        private static int AddTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        /**
         * This method takes the username and password. If they match, true is returned otherwise
         * false is return
         */
        private static bool login(string username, string password)
        {
            if (username == "admin" && password == "topSecret3")
                return true;
            return false;
        }
    }
}
