int[] myIntArray = { 5, 10, 15 };
string[] myStringArray = { "Monday", "Tuesday", "Wednesday" };

Console.WriteLine("Lenght of myIntArray: " + myIntArray.Length);
Console.WriteLine("Lenght of myStringArray: " + myStringArray.Length);

foreach (int number in myIntArray)
{
    Console.WriteLine(number);
}


foreach (string day in myStringArray)
{
    Console.WriteLine(day);

}

Console.ReadKey();
