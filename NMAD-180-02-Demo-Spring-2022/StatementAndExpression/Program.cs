using System;

namespace StatementAndExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            int height = 8;
            int weight = 200;

            Console.WriteLine("I am " + age + " and I am " + height + " feet tall and my weight is "+ weight + " lbs");
            Console.WriteLine($"I am {age} and I am {height} feet tall and my weight is {weight} lbs");
            Console.WriteLine("I am {0} and I am {1} feet tall and my weight is {2} lbs", age, height, weight);

            string myName = "Kemoy Campbell" + " Some other Names";

            int x = 5;
            int y = 3;

         
            //testing to see if 4 is divisible by 2
            Console.WriteLine(4%2==0);

            int number1 = 10;
            Console.WriteLine("number1 value is: " + number1);

            //number1 = number1 + 1;
            number1 -= 1;
            Console.WriteLine("number1 value is: " + number1);

        }
    }
}
