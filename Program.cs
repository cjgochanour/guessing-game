using System;

int SecretNumber = 42;

Console.WriteLine("Guess the secret number: ");
int UserGuess = int.Parse(Console.ReadLine());

if (UserGuess == SecretNumber)
{
    Console.WriteLine("You guessed correctly!");
}
else
{
    Console.WriteLine("You guessed incorrectly!");
}