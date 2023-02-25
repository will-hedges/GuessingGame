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
    1) Easy     (8 guesses)
    2) Medium   (6 guesses)
    3) Hard     (4 guesses)
    4) Cheater! (no limit)"
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
        case 4:
            difficultyLevel = -1;
            break;
    }
    return difficultyLevel;
}

void HandleGuess(string prompt, int secretNumber)
{
    Console.Write(prompt);
    int guess = Int32.Parse(Console.ReadLine().Trim());

    if (guess == secretNumber)
    {
        Console.WriteLine($"You guessed it!");
        Environment.Exit(0);
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

void GuessingGame(int guesses)
{
    int secretNumber = new Random().Next(1, 101);

    // let the user guess an infinite number of times
    if (guesses == -1)
    {
        while (true)
        {
            HandleGuess("Enter your guess> ", secretNumber);
        }
    }
    else
    {
        for (int i = 0; i < guesses; i++)
        {
            HandleGuess($"Enter your guess ({guesses - i} remaining)> ", secretNumber);
        }
        Console.WriteLine($"The secret number was {secretNumber}. Better luck next time!");
    }
}
