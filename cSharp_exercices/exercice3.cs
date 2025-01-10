class Program
{
    static void Main()
    {
        string question1 = "What is the capital of Brazil?";
        string answer1 = "Brasilia";

        string question2 = "What is the capital of France?";
        string answer2 = "Paris";

        int score = 0;

        Console.WriteLine(question1);
        string userAnswer1 = Console.ReadLine();
        if (userAnswer1.Trim().ToLower() == answer1.ToLower())
        {
            Console.WriteLine("Correct");
            score = score + 1;
        }
        else
        {
            Console.WriteLine("Incorrect, the answer is " + answer1);
        }
        
        Console.WriteLine("Quiz complete. Your score is " + score + "/2");
        if (score == 3)
        {
            Console.WriteLine("Congratulations, you got a perfect score!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

        Console.ReadKey();
    }
}
