using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGusserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            int guessedNumber = 0;

            bool isGuessed = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello in Guess The Number Game !!!");
            Console.ResetColor();

            while (!isGuessed)
            {
                Console.WriteLine("Please write a number from 1 to 10 : ");
                String input = Console.ReadLine();
                try
                {
                    guessedNumber = Int32.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to parse '{input}' ");
                }

                Console.ForegroundColor = ConsoleColor.Red;
                if (guessedNumber == randomNumber)
                    isGuessed = true;
                else
                    Console.WriteLine("Try again.");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Congratulations you guessed it.");
            Console.ResetColor();
            Console.WriteLine("Please press any key to end the game.");
            Console.ReadKey();

        }
    }
}
