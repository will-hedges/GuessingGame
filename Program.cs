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

    string difficultyLevel = Console.ReadLine().Trim();

    // exit if no input
    if (difficultyLevel == "")
    {
        Environment.Exit(0);
    }

    int guessesInt = Int32.Parse(difficultyLevel);

    switch (guessesInt)
    {
        case 1:
            guessesInt = 8;
            break;
        case 2:
            guessesInt = 6;
            break;
        case 3:
            guessesInt = 4;
            break;
        case 4:
            guessesInt = -1;
            break;
    }
    return guessesInt;
}

int HandleGuess(string prompt, int secretNumber)
{
    Console.Write(prompt);
    string guess = Console.ReadLine().Trim();

    // exit the loop if no input
    if (guess == "")
    {
        return -1;
    }

    int guessInt = Int32.Parse(guess);

    if (guessInt == secretNumber)
    {
        Console.WriteLine($"You guessed it!");
        return -1;
    }
    else
    {
        if (guessInt > secretNumber)
        {
            Console.WriteLine($"{guessInt} is too high.");
            return guessInt;
        }
        else
        {
            Console.WriteLine($"{guessInt} is too low.");
            return guessInt;
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
            int guess = HandleGuess("Enter your guess> ", secretNumber);
            // exit loop if no input
            if (guess == -1)
            {
                break;
            }
        }
    }
    else
    {
        for (int i = 0; i < guesses; i++)
        {
            int guess = HandleGuess($"Enter your guess ({guesses - i} remaining)> ", secretNumber);
            // exit loop if no input
            if (guess == -1)
            {
                break;
            }
        }
    }
    Console.WriteLine($"The secret number was {secretNumber}.");
}
