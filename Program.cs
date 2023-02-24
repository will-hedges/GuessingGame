using System;

GuessingGame();

void GuessingGame()
{
    int secretNumber = 42;

    Console.WriteLine("Try to guess the secret number!");
    Console.Write($"Enter your guess> ");

    for (int i = 0; i < 4; i++)
    {
        if (i > 0)
        {
            Console.Write($"Enter your guess ({i + 1})> ");
        }
        int guess = Int32.Parse(Console.ReadLine().Trim());

        if (guess == secretNumber)
        {
            Console.WriteLine($"You guessed correctly! The secret number was {secretNumber}.");
            return;
        }
        else
        {
            Console.WriteLine($"Sorry! {guess} was not the secret number.");
        }
    }
    Console.WriteLine("Better luck next time!");
}
