string MyRocket = @"
    /\
   /  \
  /____\
  |    |
  |    |
  |____|
 /|    |\
/_|____|_\
";

string myLand = @"
    /\
   /  \
  /____\
  |    |
  |    |
  |____|
 /|    |\
-|______|-
";

for (int counter = 10; counter >= 1; counter--)
{
    Console.Clear();
    Console.WriteLine("Time left to the rocker land: " + counter);
    Console.WriteLine(MyRocket);
    Thread.Sleep(1000);
    MyRocket = "\r\n" + MyRocket;
    if (counter == 1)
    {
        Console.WriteLine("The rocket has landed");
        Console.WriteLine(myLand);
    }

}

Console.ReadKey();
