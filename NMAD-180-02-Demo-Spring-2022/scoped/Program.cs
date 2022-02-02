using System;

namespace scoped
{
    class Program
    {
        static void Main(string[] args)
        {

            //scoped example
            if (true)
            {
                int number = 1;
                Console.WriteLine($"The number is {number}");
            }

            if(true)
            {
                int number = 5;
                Console.WriteLine($"Hello I am number: {number}.");
            }

            //not operator example !
            bool isRaining = false;
            isRaining = !isRaining;
            isRaining = !isRaining;

            Console.WriteLine(!isRaining);

            const int THE_MAGIC = 1256;

            Console.Write("Enter the magic number:");
            //the number is not equal to 1256

            //bool valid = ;
            int userInput;
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput != THE_MAGIC)
                {
                    Console.WriteLine("Not the magic number");
                }
                else
                {
                    //the number is equal to 1256
                    Console.WriteLine("You got it!");
                }
            } else
            {
                Console.WriteLine("Please enter a number!!!");
            }
   

        }
    }
}
