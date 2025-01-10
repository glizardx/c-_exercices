Console.WriteLine("Guess the number between 1 and 10");
Random random = new Random();

int number = random.Next(1, 10);
int userGuess = 0;
int counter = 0;

while (userGuess != number)
{
    Console.Write("Enter your guess: ");
    userGuess = int.Parse(Console.ReadLine());
    counter++;

    if (userGuess == number)
    {
        Console.WriteLine("You guessed the number! You tried " + counter + " times");
    }
    else if (userGuess < number)
    {
        Console.WriteLine("Too low! Try again!");
    }
    else
    {
        Console.WriteLine("Too high! Try again!");
    }
}
