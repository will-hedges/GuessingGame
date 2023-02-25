using System;

GuessingGame();

void GuessingGame()
{
    Console.WriteLine(" ----------------- ");
    Console.WriteLine(" | Guessing Game | ");
    Console.WriteLine(" ----------------- ");
    Console.WriteLine("Try to guess the secret number!");

    Console.WriteLine(
        $@"Please select a difficulty:
    1) Easy
    2) Medium
    3) Hard"
    );
    int difficultyLevel = Int32.Parse(Console.ReadLine().Trim());

    switch (difficultyLevel)
    {
        case 1:
            difficultyLevel = 8;
            break;
        case 2:
            difficultyLevel = 6;
            break;
        case 3:
            difficultyLevel = 4;
            break;
    }

    int secretNumber = new Random().Next(1, 101);

    for (int i = 0; i < difficultyLevel; i++)
    {
        Console.Write($"Enter your guess ({difficultyLevel - i} remaining)> ");
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
