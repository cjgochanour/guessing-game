using System;

Main();

void Main()
{
    int SecretNumber = new Random().Next(1, 101);
    int SelectedDifficulty = 0;
    Console.WriteLine("Guess the secret number!");
    while (SelectedDifficulty != 1 & SelectedDifficulty != 2 & SelectedDifficulty != 3)
    {
        Console.Write("Please select a difficulty by its number: Easy (1), Medium (2), Hard (3) > ");
        SelectedDifficulty = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Your guess ({i + 1})> ");
        int UserGuess = int.Parse(Console.ReadLine());
        if (UserGuess > SecretNumber)
        {
            Console.WriteLine($"Your guess was too high! {3 - i} guesses remain.");
        }
        else if (UserGuess < SecretNumber)
        {
            Console.WriteLine($"Your guess was too low! {3 - i} guesses remain.");
        }
        else
        {
            Console.WriteLine("You guessed correctly!");
            break;
        }
    }
}