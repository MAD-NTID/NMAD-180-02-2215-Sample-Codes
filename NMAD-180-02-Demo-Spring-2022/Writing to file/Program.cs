using System;
using System.IO;

namespace Writing_to_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Windows updating. Please do not shut down the computer.....");
            StreamWriter writer = new StreamWriter("foo.txt");
            
            writer.WriteLine("Hello world. I am modifying a file!!!!");
            writer.Close();

       
            Console.WriteLine("Update complete");
        }
    }
}
