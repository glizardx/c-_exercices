int addTwoValues(int value1, int value2)
{
    int result = value1 + value2;
    return result;
}

Console.WriteLine("The number you entered here, i'll add 10 to it!");
int num1 = int.Parse(Console.ReadLine());

int myResult = addTwoValues(num1, 10);
Console.WriteLine($"The result is: {myResult}");

Console.ReadKey();
