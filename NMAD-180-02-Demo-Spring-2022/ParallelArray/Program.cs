using System;

namespace ParallelArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];
            double[] grades = new double[4];

            for(int i = 0; i <  names.Length; i++)
            {
                Console.Write("What is your name: ");
                string name = Console.ReadLine();

                Console.Write("What is your grade: ");
                double grade = double.Parse(Console.ReadLine());

                names[i] = name;
                grades[i] = grade;
            }

            int index = 0;
            while(index < names.Length)
            {
                Console.WriteLine($"{names[index]} : {grades[index]}");
                index++;
            }
        }
    }
}
