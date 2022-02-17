using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];
            names[0] = "Marisa";
            names[1] = "Jared";
            names[2] = "Lucas";
            names[3] = "Amir";

            Console.WriteLine("For loop");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("\n\nForeach");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            //sorted?
            Array.Sort(names);
            Console.WriteLine("\nAm I sorted?");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Reversed?
            Array.Reverse(names);
            Console.WriteLine("\nAm I reversed?");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
