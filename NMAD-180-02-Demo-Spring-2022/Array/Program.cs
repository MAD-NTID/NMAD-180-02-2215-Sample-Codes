using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //we create a variable to hold an array of 5 numbers
            int[] numbers = new int[5];

            //array are index are 0 based so we start counting from 0
            //assigning numbers to the array indexes
            Console.WriteLine("Example of hardcoded array values");
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 7;
            numbers[3] = 9;
            numbers[4] = 10;

            Console.WriteLine($"Item 0 : {numbers[0]}");
            Console.WriteLine($"Item 1 : {numbers[1]}");
            Console.WriteLine($"Item 2 : {numbers[2]}");
            Console.WriteLine($"Item 3 : {numbers[3]}");
            Console.WriteLine($"Item 4 : {numbers[4]}");


            //example of taking a input from the user and assign it to the first index in the array
            Console.WriteLine("\nExample of taking input from the user and add to array");
            int[] nums = new int[3];
            Console.Write("Enter a number to add to the first index in the array:");
            int input = int.Parse(Console.ReadLine());
            nums[0] = input; // take the first number and assign it to the first element in the array

            //assign 3 and 6 to the other two indexes
            nums[1] = 3;
            nums[2] = 6;

            Console.WriteLine($"The sum of all 3 numbers {input} + 3 + 6 = {nums[0] + nums[1] + nums[2]}");


        }
    }
}
