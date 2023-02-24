using System;

GuessingGame();

void GuessingGame()
{
    int secretNumber = new Random().Next(1, 101);

    Console.WriteLine("Try to guess the secret number!");

    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Enter your guess ({4 - i} guesses remaining)> ");
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
    Console.WriteLine($"The secret number was {secretNumber}. Better luck next time!");
}
