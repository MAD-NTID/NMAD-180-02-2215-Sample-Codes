using System;

namespace PrefixPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int j = 5;

            //  Prefix
            int p = ++j; // j is increment before assigned to p

            Console.WriteLine("prefix, should be 6: {0}",j);  // This is 6

            //  Postfix
            int y = x++; //x is assigned to y then x increment its value by 1

            Console.WriteLine($"postfix, should be 5: {y}");   // This is 5
            Console.WriteLine("X should show 6 because it was increment after assigning to y: " + x);   // This is 6

        }
    }
}
