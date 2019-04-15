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
            String input = null;

            bool hasDecided = false;
            bool isTrying = true;

            printInColor(ConsoleColor.Green,"Hello in Guess The Number Game !!!");
            
            while (isTrying)
            {
                hasDecided = false;
                Console.WriteLine("Please write a number from 1 to 10 : ");
                input = Console.ReadLine();
                try
                {
                    guessedNumber = Int32.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to parse '{input}' ");
                }

                if (guessedNumber == randomNumber)
                {
                    printInColor(ConsoleColor.Yellow, "Congratulations you guessed it.");
                    while (!hasDecided)
                    {
                        printInColor(ConsoleColor.Yellow, "Do you want to try again ? (Y/N) ");
                        input = Console.ReadLine();
                        if (input.Equals("N"))
                        {
                            isTrying = false;
                            hasDecided = true;
                        }
                        else if (input.Equals("Y"))
                        {
                            randomNumber = random.Next(1, 10);
                            isTrying = true;
                            hasDecided = true;
                        }
                        else
                        {
                            hasDecided = false;
                        }
                    }
                }
                else
                    printInColor(ConsoleColor.Red, "Try again.");
            }
            

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
