using System;

namespace FunWithMethods
{
    class Program
    {
        const int NUM1 = 5;
        const int NUM2 = 2;
        static void Main(string[] args)
        {

            Console.WriteLine("The default value is: {0}", multiply());
            Console.WriteLine("The non default value is: {0}", multiply(4,3));
            int sum = AddNumbers(NUM1, NUM2);
            Console.WriteLine("The sum of 5 + 2 is {0}", sum);

            Console.WriteLine();
            Console.WriteLine("The sum of 5 + 2 is {0}", AddNumbers(NUM1,NUM1));

            Console.WriteLine("The sum of 10000 + (-10000) is {0}", AddNumbers(10000, -10000));


            Console.WriteLine("The sum of 10000 + (-10000000) is {0}", AddNumbers(10000, -10000000));

            Console.WriteLine("The sum of 10000 + 1 + 1 is {0}", AddNumbers(10000, 1,1));

            Console.WriteLine("The sum of 1000.1 + 1.1 is {0}", AddNumbers(1000.1, 1.1));

            Console.WriteLine("The sum of 5 + 5 is {0}", AddNumbers("5", "5"));
        }

        private static int multiply(int num1 = 6, int num2 = 5)
        {
            return num1 * num2;
        }

        private static int AddNumbers(int num1, int num2)
        {

            //return num1 + num2;


            int sum = num1 + num2;
            return sum;
        }

        private static int AddNumbers(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        private static int AddNumbers(double num1, double num2)
        {
            return (int)(num1 + num2);
        }

        private static int AddNumbers(string num1, string num2)
        {
            
            return int.Parse(num1) + int.Parse(num2);

            //using an existing method
            //return AddNumbers(int.Parse(num1), int.Parse(num2));
        }
    }
}
