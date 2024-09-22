using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guessNumber = -1;
            int guesses = 0;

            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                guesses++;

                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! Your guesses are {guesses}");
                }

            }
            Console.WriteLine("Do you want to play again? (Yes/No) ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
            {
                playAgain = false;
            }
        }

    }
}