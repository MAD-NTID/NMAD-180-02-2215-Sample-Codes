using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {



            Fruit banana = new Fruit("Yellow", "slushy", "Banana");

            Console.WriteLine(banana.name);
            Console.WriteLine(banana.color);
            Console.WriteLine(banana.texture);
            if(!banana.IsRipe())
            {
                Console.WriteLine("Try again tomorrow!"); 
            }else
            {
                Console.WriteLine("You may eat this banana");
            }

            //Environment.Exit(0);

            Grade[] grades = new Grade[4];
            const int MAX = 4;

            for(int i = 0; i< 2; i++)
            {
                Grade grade = new Grade();

                Console.Write("Enter first your name: ");
                grade.firstName = Console.ReadLine();

                Console.Write("Enter your last name:");
                grade.lastName = Console.ReadLine();

                Console.Write("Enter the course name:");
                grade.courseName = Console.ReadLine();

                Console.Write("Enter the grade letter:");
                grade.score = int.Parse(Console.ReadLine());

                //add to the grade array
                grades[i] = grade;
               
            }


            //grade.firstName = "Kemoy";
            //grade.lastName = "Campbell";
            //grade.courseName = "NMAD-180";
            //grade.gradeLetter = "D";

            Console.WriteLine("\n Student Records");

            for(int i = 0; i< 2; i++)
            {
                Console.WriteLine(grades[i].Record());
                if (grades[i].IsPassed())
                {
                    Console.WriteLine("Passed!");
                } else
                {
                    Console.WriteLine("See you again next semester... evil grin");
                }

            }

 
         



        }
    }
}
