using System;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int attempts = 0;
            int guess = 0;
            bool isValidInput;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I've picked a number between 1 and 100. Can you guess it?");

            while (guess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                isValidInput = int.TryParse(Console.ReadLine(), out guess);

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                attempts++;

                if (guess < numberToGuess)
                    Console.WriteLine("Too low! Try again.");
                else if (guess > numberToGuess)
                    Console.WriteLine("Too high! Try again.");
            }

            Console.WriteLine($"Congratulations! You guessed the number {numberToGuess} in {attempts} attempts!");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
