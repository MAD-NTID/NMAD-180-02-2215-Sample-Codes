using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            //implicity conversion
            double numberA = number;
            Console.WriteLine(numberA);



            double numberB = 4.77777774;
            int numberC = (int)numberB;
            int numberD = Convert.ToInt32(numberB);

            Console.WriteLine(numberD);
            Console.WriteLine(numberC);
        }
    }
}
