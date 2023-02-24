using System;

GuessingGame();

void GuessingGame()
{
    int secretNumber = 42;

    Console.WriteLine("Try to guess the secret number!");

    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Enter your guess: ");
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
