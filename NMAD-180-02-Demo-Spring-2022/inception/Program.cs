using System;

namespace inception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
   
                case 1:
                case 2:
                    Console.WriteLine($"I am  option {option} and I jumped in the dream #2");
                    break;
                default:
                    Console.WriteLine("I have no idea who you are.... turn around");
                    break;
            }
        }
    }
}
