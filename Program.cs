Random random = new Random();
int guess = 0;
string welcomeMessage = "Welcome to Guess It Right. Guess a number between 1 and 20";
int num = random.Next(1, 20);

Console.WriteLine(welcomeMessage);
Console.WriteLine("-----------------------------------------------------------");

int i = 0;

while (guess != num)
{
    try
    {
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess > num)
        {
            Console.WriteLine("Too high. Guess again");
        }

        else if (guess == num)
        {
            Console.WriteLine("You guessed the number");
        }

        else
        {
            Console.WriteLine("Too low, try again");
        }
    }
    catch 
    {
        Console.WriteLine("Guess must be a number");
        i--;
    }
    i++;
}
Console.WriteLine($"Congrats, it took you {i} attempts");
Console.ReadLine();