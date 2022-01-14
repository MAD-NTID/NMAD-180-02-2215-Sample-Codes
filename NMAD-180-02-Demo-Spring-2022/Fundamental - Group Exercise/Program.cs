using System;

/**
 * Purpose: This program shows my name, age and major on the console.
 *          It is a good introduction to the fundamental of c# and variables
 *          
 *Author: Kemoy Campbell
 *Email:  classified@rit.edu
 *Date: 1/13/2022
 * 
 */
namespace Fundamental___Group_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //a variable to store the age
            int age = 101;

            //a variable to store the name
            string name = "Kemoy Campbell";

            //a variable to store the major 
            string major = "Computer Science";

            //remember to put the variables in the same order as the place holders {0}, {1} .. etc
            //Also remember that in programming, counting start at 0 hence why the first place holder is {0}
            //not {1}
            Console.WriteLine("Hello my name is {0} and I am {1} years old. My major is {2}.", name, age, major);
        }
    }
}
