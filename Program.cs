using System;

int SecretNumber = 42;

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Guess the secret number: ");
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