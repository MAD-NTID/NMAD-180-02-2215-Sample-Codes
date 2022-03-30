using System;

namespace FunWIthEnum
{
    class Program
    {
        enum Options
        {
            OptionOne = 1,
            OptionTwo,
            OptionThree,
            OptionFour,
            OptionFive
        }

        static void Main(string[] args)
        {

            string[] labels = Enum.GetNames(typeof(Options));
            //t[] values = Enum.GetValues(typeof(Options));
            foreach(string label in labels)
            {
                Console.WriteLine(label);
            }
            while(true)
            {
                Console.Write("Enter a option:");
                string inputString = Console.ReadLine();
                int inputInt = int.Parse(inputString);

                Options input = (Options)inputInt;

                Console.WriteLine((int) input);
            }

   
            //Console.WriteLine($"{Options.OptionFour} is {(int)Options.OptionFour}");
        }
    }
}
