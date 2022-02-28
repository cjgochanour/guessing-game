using System;

Main();

void Main()
{
    int selectedDifficulty = 0;
    Console.WriteLine("Guess the secret number!");
    while (selectedDifficulty != 1 & selectedDifficulty != 2 & selectedDifficulty != 3 & selectedDifficulty != 4)
    {
        Console.Write("Please select a difficulty by its number: Easy (1), Medium (2), Hard (3) Cheater (4) > ");
        selectedDifficulty = int.Parse(Console.ReadLine());
    }
    switch (selectedDifficulty)
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
        case 4:
            TheGame(2147483647);
            break;
    }
}

void TheGame(int MaxGuesses)
{
    int secretNumber = new Random().Next(1, 101);
    for (int i = 0; i < MaxGuesses; i++)
    {
        Console.Write($"Your guess ({i + 1})> ");
        int userGuess = int.Parse(Console.ReadLine());
        if (userGuess > secretNumber)
        {
            Console.WriteLine($"Your guess was too high! {MaxGuesses - 1 - i} guesses remain.");
        }
        else if (userGuess < secretNumber)
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