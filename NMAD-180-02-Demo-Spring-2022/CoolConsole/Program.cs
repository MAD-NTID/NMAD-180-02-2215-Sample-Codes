using System;

namespace CoolConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Title = "My Million dollaz console!!!";
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("Hello World!");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello whoever you are!");

            //add this line so you can see the console title
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
        }
    }
}
