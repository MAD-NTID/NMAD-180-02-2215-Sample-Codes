using System;

namespace ArrayFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 50;
            numbers[1] = 10;
            numbers[2] = 30;
            numbers[3] = 70;
            numbers[4] = -1;

            //unordered array
            Console.WriteLine("Unordered numbers");
            for(int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine($"item {index} :  {numbers[index]}");
            }


            Array.Sort(numbers);
            Console.WriteLine("Ordered numbers");
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine($"item {index} :  {numbers[index]}");
            }

            Console.WriteLine("Reversing the array");
            Array.Reverse(numbers);
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine($"item {index} :  {numbers[index]}");
            }
        }
    }
}
