using System;

int SecretNumber = 42;
Console.WriteLine("Guess the secret number!");

for (int i = 0; i < 4; i++)
{
    Console.Write($"Your guess ({i + 1})> ");
    int UserGuess = int.Parse(Console.ReadLine());
    if (UserGuess != SecretNumber)
    {
        Console.WriteLine("You guessed incorrectly!");
    }
    if (UserGuess == SecretNumber)
    {
        Console.WriteLine("You guessed correctly!");
        break;
    }
}

// if (UserGuess == SecretNumber)
// {
//     Console.WriteLine("You guessed correctly!");
// }
// else
// {

// }