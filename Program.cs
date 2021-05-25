using System;

int attRemaining;
string difficulty;
bool difficultyCheck = true;
int secretNum = new Random().Next(1, 100);

while (difficultyCheck)
{
    Console.WriteLine("Choose Your Difficulty!");
    Console.Write("Easy/Medium/HARD/Cheater? > ");
    string answer = Console.ReadLine().ToLower();
    if (answer == "easy")
    {
        difficulty = "easy";
        attRemaining = 7;
        difficultyCheck = false;
        Main();
    }
    else if (answer == "medium")
    {
        difficulty = "medium";
        attRemaining = 5;
        difficultyCheck = false;
        Main();
    }
    else if (answer == "hard")
    {
        difficulty = "hard";
        attRemaining = 3;
        difficultyCheck = false;
        Main();
    }
    else if (answer == "cheater")
    {
        attRemaining = 0;
        difficulty = "cheater";
        difficultyCheck = false;
        Main();
    }
    else
    {
        Console.WriteLine("Please select a real difficulty...");
    };
}

void Main()
{
    Console.WriteLine("Guess the secret number.");
    Console.Write("Your guess? ");
    string guess = Console.ReadLine();
    int numGuess = int.Parse(guess);

    try
    {
        if (numGuess == secretNum && attRemaining >= 0 && difficulty != "cheater")
        {
            Console.WriteLine("You guessed correctly!");
            Console.Beep();
        }
        else if (attRemaining == 0 && difficulty != "cheater")
        {
            Console.WriteLine("Wrong. No more guesses");
        }
        else if (numGuess > secretNum && attRemaining > 0 && difficulty != "cheater")
        {
            Console.WriteLine($"WRONG, TOO HIGH. Try again. (Attempts remaining {attRemaining})");
            attRemaining--;
            Main();
        }
        else if (numGuess > secretNum && difficulty == "cheater")
        {
            Console.WriteLine("That's too high, but it's ok. Keep trying. You can do it!");
            Main();
        }
        else if (numGuess < secretNum && difficulty == "cheater")
        {
            Console.WriteLine("That's too low, but it's ok. Keep trying. You can do it!");
            Main();
        }
        else if (numGuess == secretNum && difficulty == "cheater")
        {
            Console.WriteLine("Wow!! You're so smart!");
            Console.Beep();
        }
        else if (numGuess < secretNum && difficulty != "cheater")
        {
            Console.WriteLine($"WRONG, TOO Low. Try again. (Attempts remaining {attRemaining})");
            attRemaining--;
            Main();
        }
    }
    catch
    {
        Console.WriteLine("...it's a number...");
        Main();
    };
};





