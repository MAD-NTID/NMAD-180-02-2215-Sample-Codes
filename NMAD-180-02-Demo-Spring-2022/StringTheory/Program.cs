using System;

namespace StringTheory
{
    class Program
    {
        static void Main(string[] args)
        {

            //string wordyWordy = "Hello World. I just wanna announce my spacy!";
            //string[] spilty = wordyWordy.Split(" ");
            //for(int i = 0; i< spilty.Length; i++)
            //{
            //    Console.WriteLine(spilty[i]);
            //}

            //Console.WriteLine("The length is: " + spilty.Length);

            string students = "Erik M, Marisa M, Jared H, Amir E, Lucas S";

            string[] studentArray = students.Split(", ");

            foreach (string stud in studentArray)
            {
                Console.WriteLine(stud);
            }


            Console.WriteLine("Elite Student Searching Database");
            while (true)
            {
                Console.Write("Enter student name:");
                string student = Console.ReadLine().ToUpper();

                if (students.ToUpper().IndexOf(student) >= 0)
                {
                    Console.WriteLine($"{student} found!!!");
                }
                else
                {
                    Console.WriteLine($"I have no idea who {student} is!");
                }

            }




            string words = "Hello World!";

            //change string to array of characters
            char[] wordToChars = words.ToCharArray();

            Array.Reverse(wordToChars);

            string newWordReverse = new string(wordToChars);
            Console.WriteLine("I am reversed: " + newWordReverse);
            //for(int i = 0; i< wordToChars.Length; i++)
            //{
            //    Console.WriteLine(wordToChars[i]);
            //}

            //Console.WriteLine();
            //foreach(char letter in wordToChars)
            //{
            //    Console.WriteLine(letter);
            //}

            /* Console.WriteLine(words.ToUpper());
             Console.WriteLine(words.ToLower());
            */

            //showing only World! from the string
            Console.WriteLine(words.Substring(6));

            Console.Write("Do you want Ice cream? (Y/N):");
            string response = Console.ReadLine();

            if (response.ToUpper() == "Y")
            {
                Console.WriteLine("Here you go!");
            }
            else
            {
                Console.WriteLine("Boo!");
            }
        }
    }
}
