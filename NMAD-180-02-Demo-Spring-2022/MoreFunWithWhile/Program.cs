using System;

namespace MoreFunWithWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            //Using while loop, break and continue
            while(true)
            {
                Console.WriteLine("Do you like this class, Y/N: - Infinity approach");
                string res = Console.ReadLine().ToUpper();

                //continue to prompt the user to enter a response until it is Y or NO
                if (res != "Y" && res != "N")
                {
                    Console.WriteLine("Invalid respoonse!!");
                    continue; //user is redirect to the prompt if an invalid response is entered
                }
                    

                //this only get hits and break out of the loop if the response is yes or no
                break;
            }



            char response;
            do
            {
                Console.WriteLine("Do you like this class,Y/N: ");
                char.TryParse(Console.ReadLine().ToUpper(), out response);
                switch(response)
                {
                    case 'Y':
                        Console.WriteLine("You entered yes");
                        break;
                    case 'N':
                        Console.WriteLine("You entered no");
                        break;
                    default:
                        Console.WriteLine("Invalid response!!");
                        break;
                }
                
                // USING IF APPROACH - COMMENT OUT SWITCH AND UNCOMMENT THIS LINE

                //if (char.TryParse(Console.ReadLine(), out response) && response == 'Y')
                //{
                //    Console.WriteLine("You entered yes");
                //}
                //else if (response == 'N')
                //{
                //    Console.WriteLine("You entered no");
                //}
                //else
                //{
                //    Console.WriteLine("Invalid response!!");
                //}
            } while (response != 'Y' && response != 'N');
            



            //Using while loop approach

            //char response;
            //do
            //{
            //    Console.Write("Enter Y or N:");
            //    char.TryParse(Console.ReadLine().ToUpper(), out response);
            //} while (response != 'Y' && response != 'N');

            //response = 'S';
            //while(response != 'Y' && response != 'N')
            //{
            //    Console.Write("Enter Y or N: (while loop)");
            //    char.TryParse(Console.ReadLine().ToUpper(), out response);
            //}
        }
    }
}
