using System;

Main();

void Main()
{
    DisplayPrompt();
}

void DisplayPrompt()
{
    Console.WriteLine("Try to guess the secret number!");
    Console.Write($"Enter your guess: ");
    string guess = Console.ReadLine().Trim();
    Console.Write($"You guessed {guess}.");
}
