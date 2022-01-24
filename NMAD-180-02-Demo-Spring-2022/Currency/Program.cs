using System;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            int donut = 10;
            int chocolateBar = 100;


            Console.WriteLine("total items: {0} \nSubtotal: {1:C}", 4, (donut + chocolateBar));
        }
    }
}
