using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a welcome message
            Console.WriteLine("Welcome to My Game!");

            // Main game loop
            while (true)
            {
                // Prompt the user for input
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Check if the user entered "quit"
                if (input.ToLower() == "quit")
                {
                    break;
                }

                // Parse the user's guess
                int guess;
                if (!int.TryParse(input, out guess))
                {
                    // The user did not enter a valid number
                    Console.WriteLine("Invalid input. Please enter a number or 'quit' to exit.");
                    continue;
                }

                // Generate a random number for the user to guess
                Random rand = new Random();
                int number = rand.Next(1, 10);

                // Check if the user's guess is correct
                if (guess == number)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                }
                else
                {
                    Console.WriteLine("Sorry, that is not correct. The correct number was {0}.", number);
                }
            }
        }
    }
}
