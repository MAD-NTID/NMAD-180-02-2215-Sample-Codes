using System;

namespace Inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Whoa!!!! You cant be {age}");
        }
    }
}
