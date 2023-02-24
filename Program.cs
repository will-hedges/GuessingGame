using System;

Main();

void Main()
{
    int secret = SecretNumber(42);
    GuessingGame(secret);
}

void GuessingGame(int secretNumber)
{
    Console.WriteLine("Try to guess the secret number!");
    Console.Write($"Enter your guess: ");

    int guess = Int32.Parse(Console.ReadLine().Trim());
    if (guess == secretNumber)
    {
        Console.WriteLine($"You guessed correctly! The secret number was {secretNumber}.");
    }
    else
    {
        Console.WriteLine($"Sorry! {guess} was not the secret number.");
    }
}

int SecretNumber(int num)
{
    return num;
}
