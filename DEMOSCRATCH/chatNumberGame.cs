using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the guess a number game!");

        bool playAgain = true;
        Random randomGenerator = new Random();

        while (playAgain)
        {
            int magicNum = randomGenerator.Next(1, 100);
            int attempts = 0;

            Console.WriteLine("Please guess a number from 1 to 100 (integers only, please).");

            bool guessedCorrectly = false;
            while (!guessedCorrectly)
            {
                attempts++;
                Console.Write("Guess: ");
                int guessNum;

                // Validate user input
                while (!int.TryParse(Console.ReadLine(), out guessNum))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("Guess: ");
                }

                if (guessNum > magicNum)
                {
                    Console.WriteLine("Guess Lower");
                }
                else if (guessNum < magicNum)
                {
                    Console.WriteLine("Guess Higher");
                }
                else // guessNum == magicNum
                {
                    Console.WriteLine($"Congrats! You guessed it in {attempts} attempts.");
                    guessedCorrectly = true;
                }
            }

            // Ask user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string playChoice = Console.ReadLine().ToLower();

            while (playChoice != "yes" && playChoice != "no")
            {
                Console.Write("Invalid input. Do you want to play again? (yes/no): ");
                playChoice = Console.ReadLine().ToLower();
            }

            if (playChoice == "no")
            {
                playAgain = false;
            }
            Console.WriteLine(); // Just for spacing
        }

        Console.WriteLine("Thanks for playing!");
    }
}
