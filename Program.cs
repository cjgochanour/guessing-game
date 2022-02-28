using System;

Main();

void Main()
{
    int SecretNumber = new Random().Next(1, 101);
    Console.WriteLine("Guess the secret number!");
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Your guess ({i + 1})> ");
        int UserGuess = int.Parse(Console.ReadLine());
        if (UserGuess != SecretNumber)
        {
            Console.WriteLine($"You guessed incorrectly! {4 - (i + 1)} guesses remain.");
        }
        if (UserGuess == SecretNumber)
        {
            Console.WriteLine("You guessed correctly!");
            break;
        }
    }
}



// if (UserGuess == SecretNumber)
// {
//     Console.WriteLine("You guessed correctly!");
// }
// else
// {

// }