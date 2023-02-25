using System;

GuessingGame();

void GuessingGame()
{
    int secretNumber = new Random().Next(1, 101);

    Console.WriteLine("Try to guess the secret number!");

    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Enter your guess ({4 - i} remaining)> ");
        int guess = Int32.Parse(Console.ReadLine().Trim());

        if (guess == secretNumber)
        {
            Console.WriteLine($"You guessed it!");
            return;
        }
        else
        {
            if (guess > secretNumber)
            {
                Console.WriteLine($"{guess} is too high.");
            }
            else
            {
                Console.WriteLine($"{guess} is too low.");
            }
        }
    }
    Console.WriteLine($"The secret number was {secretNumber}. Better luck next time!");
}
