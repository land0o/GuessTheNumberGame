using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();
            int secretNumber = randomNumberGenerator.Next(1, 101);

            Console.WriteLine("Please select difficulty from easy, medium, hard");
            string difficulty = Console.ReadLine();
            string selectionOfDifficulty = difficulty;
            Console.WriteLine($"Your selection {selectionOfDifficulty} ");
            int numGuesses = 0;
            if (selectionOfDifficulty == "easy")
            {
                numGuesses = 8;
            }
            else if (selectionOfDifficulty == "medium")
            {
                numGuesses = 6;
            }
            else if (selectionOfDifficulty == "hard")
            {
                numGuesses = 4;
            }

            Console.WriteLine("Please guess a number!");
            for (int i = 0; i < numGuesses; i++)
            {
                Console.Write($"Your Guess ({numGuesses - i})> ");
                string guess = Console.ReadLine();
                int intGuess = int.Parse(guess);
                if (intGuess == secretNumber)
                {
                    Console.WriteLine("You got it right!");
                    break;
                }
                else if (intGuess > secretNumber)
                {
                    Console.WriteLine("Guess is too high!");
                    Console.WriteLine($"Nope the answer is {secretNumber}");
                }
                else //if (intGuess < secretNumber) is not needed 
                {
                    Console.WriteLine("Guess is too low!");
                }
            }


        }
    }
}
