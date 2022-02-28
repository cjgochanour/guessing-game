using System;

Main();

void Main()
{
    int SelectedDifficulty = 0;
    Console.WriteLine("Guess the secret number!");
    while (SelectedDifficulty != 1 & SelectedDifficulty != 2 & SelectedDifficulty != 3)
    {
        Console.Write("Please select a difficulty by its number: Easy (1), Medium (2), Hard (3) > ");
        SelectedDifficulty = int.Parse(Console.ReadLine());
    }
    switch (SelectedDifficulty)
    {
        case 1:
            TheGame(8);
            break;
        case 2:
            TheGame(6);
            break;
        case 3:
            TheGame(4);
            break;
    }
}

void TheGame(int MaxGuesses)
{
    int SecretNumber = new Random().Next(1, 101);
    for (int i = 0; i < MaxGuesses; i++)
    {
        Console.Write($"Your guess ({i + 1})> ");
        int UserGuess = int.Parse(Console.ReadLine());
        if (UserGuess > SecretNumber)
        {
            Console.WriteLine($"Your guess was too high! {MaxGuesses - 1 - i} guesses remain.");
        }
        else if (UserGuess < SecretNumber)
        {
            Console.WriteLine($"Your guess was too low! {MaxGuesses - 1 - i} guesses remain.");
        }
        else
        {
            Console.WriteLine("You guessed correctly!");
            break;
        }
    }
}