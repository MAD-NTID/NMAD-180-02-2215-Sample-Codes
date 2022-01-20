using System;

namespace CoolConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Million dollaz console!!!";
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello whoever you are!");
        }
    }
}
