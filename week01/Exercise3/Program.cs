using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Random number generation
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        magicNumber = 49;
        int numOfGuesses = 0;
        numOfGuesses += 1;

        int guess = -1;

        // Add a loop that keeps looping as long as the guess does not match the magic number.
        // At this point, the user should be able to keep playing until they get the correct answer

        while (guess != magicNumber)
        {
            // Start by asking the user for the magic number
            Console.Write("What is your guess of the magic number?: ");
            string input = Console.ReadLine();

            // Convert the input to an integer
            guess = int.Parse(input);

            // Check if the guess is correct
            if (guess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed it right!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("Lower!");
            }

            {
                // Count the number of guesses
                numOfGuesses += 1;
            }

            Console.WriteLine($"You have made {numOfGuesses} guesses so far.");
        }


    }
}

