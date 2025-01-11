using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int SecretNumber = random.Next(1, 51); 
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("Guess the secret number between 1 and 50");

        while (guess != SecretNumber)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < SecretNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (guess > SecretNumber)
            {
                Console.WriteLine("Too high");
            }

            attempts++;
        }

        Console.WriteLine("You guessed the secret number in {0} attempts", attempts);
        Console.ReadKey();
    }
}
