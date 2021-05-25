using System;

Console.WriteLine("Guess the secret number.");
Console.Write("Your guess? ");
string guess = Console.ReadLine();
int numGuess = int.Parse(guess);
int secretNum = 42;

if (numGuess == secretNum)
{
    Console.WriteLine("You guessed correctly!");
}
else
{
    Console.WriteLine("WRONG.");
};



