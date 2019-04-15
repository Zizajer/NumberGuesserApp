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

            printInColor(ConsoleColor.Green,"Hello in Guess The Number Game !!!");
            
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
                
                if (guessedNumber == randomNumber)
                    isGuessed = true;
                else
                    printInColor(ConsoleColor.Red,"Try again.");
            }

            printInColor(ConsoleColor.Yellow, "Congratulations you guessed it.");

            Console.WriteLine("Please press any key to end the game.");
            Console.ReadKey();

        }

        public static void printInColor(ConsoleColor color, String message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
