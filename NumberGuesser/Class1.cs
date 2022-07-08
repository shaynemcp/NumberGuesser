using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Prompts
    {
        static void instructions()
        {
            Console.WriteLine("As a player, you will input a guess from 1 through 10");
            
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Thank you {0}, we will now begin.", name);
        }

        static void guesser()
        {
            Console.WriteLine("Insert a number now.");
            int guess = 0;

            while(guess != 0)
            {
               guess = Console.Read();

               if(guess == 10)
                {
                    Console.WriteLine("You have guessed correctly, the number is 10");
                    break;
                }
            }
        }
    }
}
