using System;

namespace GradeLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GRADE_LETTER_A = 90;
            const int HUNDRED = 100;
            const int GRADE_LETTER_B = 80;
            const int GRADE_LETTER_C = 70;
            const int GRADE_LETTER_D = 60;
            const int ZERO = 0;

            Console.Write("What is your grade:");

 

            //user entered a valid number
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                if(grade>=0 && grade<=HUNDRED)
                {
                    if (grade >= GRADE_LETTER_A && grade <= HUNDRED)
                    {
                        Console.WriteLine("You have got an A grade");
                    }
                    else if (grade >= GRADE_LETTER_B)
                    {
                        Console.WriteLine("You have got an B grade");
                    }
                    else if (grade >= GRADE_LETTER_C)
                    {
                        Console.WriteLine("You have got an C grade");
                    }
                    else if (grade >= GRADE_LETTER_D)
                    {
                        Console.WriteLine("You have got an D grade");
                    } else
                    {
                        Console.WriteLine("You have got an F grade");
                    }
                } else
                {
                    Console.WriteLine($"Please enter a grade between {ZERO}-{HUNDRED}");
                }
 
            } else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
