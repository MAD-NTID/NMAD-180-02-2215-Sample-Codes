using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Remember programming typically start counting at 0
             */
            Console.WriteLine("Example of using while loop");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            //for loop example
            Console.WriteLine("\nExample of using for loop");
            for (int counter2 = 0; counter2 < 10; counter2++)
            {
                Console.WriteLine(counter2);
            }

            //example of using a while to take input
            Console.WriteLine("Example of using a while loop to take inputs from the user");
            double[] grades = new double[5];
            int counter3 = 0;
            while (counter3 < 5)
            {
                Console.Write($"Enter grade {counter3 + 1}:");
                //double grade = double.Parse(Console.ReadLine());

                grades[counter3] = double.Parse(Console.ReadLine());
                counter3++;
            }


            //for loop to show all grades
            Console.WriteLine("Example of using a for loop to show all the entered grades");
            double sum = 0;
            for (int index = 0; index < grades.Length; index++)
            {
                sum += grades[index];

                Console.WriteLine($"grade {index + 1} : {grades[index]}");
            }

            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Average: {0}", sum / grades.Length);
        }
    }
}
