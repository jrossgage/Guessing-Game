using System;


int secretNum = 42;
int attempts = 1;
Main();

void Main()
{
    Console.WriteLine("Guess the secret number.");
    Console.Write("Your guess? ");
    string guess = Console.ReadLine();
    int numGuess = int.Parse(guess);


    if (numGuess == secretNum && attempts < 4)
    {
        Console.WriteLine("You guessed correctly!");
    }
    else if (attempts >= 4)
    {
        Console.WriteLine("Wrong. No more guesses");
    }
    else
    {
        Console.WriteLine("WRONG. Try again");
        attempts++;
        Main();
    };

};





