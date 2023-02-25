using System;

Main();

void Main()
{
    DisplayWelcome();
    int numberOfGuesses = GetDifficulty();
    GuessingGame(numberOfGuesses);
}

void DisplayWelcome()
{
    Console.WriteLine(" ----------------- ");
    Console.WriteLine(" | Guessing Game | ");
    Console.WriteLine(" ----------------- ");
    Console.WriteLine("Try to guess the secret number!");
}

int GetDifficulty()
{
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
    return difficultyLevel;
}

void GuessingGame(int guesses)
{
    int secretNumber = new Random().Next(1, 101);

    for (int i = 0; i < guesses; i++)
    {
        Console.Write($"Enter your guess ({guesses - i} remaining)> ");
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
