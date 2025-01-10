int currentScore;
int sum = 0;
int counter = 0;

do
{
    Console.WriteLine("Enter your student's score. -1 to quit");
    currentScore = int.Parse(Console.ReadLine());
    if (currentScore != -1)
    {
        sum = sum + currentScore;
        counter++;
    }
}   while(currentScore != -1);

int average = sum / counter;
Console.WriteLine("The average score is: " + average);
Console.ReadKey();
