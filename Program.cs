﻿Random random = new Random();
int guess = 0;
string welcomeMessage = "Welcome to Guess It Right. Guess a number between 1 and 500";
int num = random.Next(1, 501);
Console.WriteLine(welcomeMessage);

int i = 0;

while (guess != num)
{
    try
    {
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess > num)
        {
            Console.WriteLine("Hmmmmm, too High. Guess again");
        }

        else
        {
            Console.WriteLine("Too low, try again");
        }
    }
    catch 
    {
        Console.WriteLine("Guess must be a number");
        i++;
    }
    Console.WriteLine($"Congrats, it took you {i} attempts");
    Console.ReadLine();
}