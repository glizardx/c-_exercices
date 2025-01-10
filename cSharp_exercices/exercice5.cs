Console.WriteLine("Welcome to the adventure game!");
Console.WriteLine("Enter your name:");
string characterName = Console.ReadLine();
Console.WriteLine("Choose your class: Warrior, Mage, Archer");
string characterClass = Console.ReadLine();

Console.WriteLine($"Hello, {characterName}, the {characterClass}, you are lost in the forest. You have to find your way out.");
Console.WriteLine("You have to choose between two paths: left or right");
string path = Console.ReadLine();

if (path == "left")
{
    Console.WriteLine("You have encountered a lion! You have to fight it!");
    Console.WriteLine("Choose a weapon: sword, bow or staff");
    string weapon = Console.ReadLine();
    
    if (weapon == "sword")
    { 
        Console.WriteLine("You have defeated the lion with your sword! You can continue your journey.");
    }
    else if (weapon == "bow")
    {
        Console.WriteLine("You have defeated the lion with your bow! You can continue your journey.");
    }
    else if (weapon == "staff")
    {
        Console.WriteLine("You have defeated the lion with your staff! You can continue your journey.");
    }
    else
    {
        Console.WriteLine("You have chosen an invalid weapon. You have been defeated by the lion.");
    }
}
else if (path == "right")
{
    Console.WriteLine("You have encountered a treasure chest! You have to open it!");
    Console.WriteLine("Choose your lockpicking tool: Lockpick, Magic, Arrow");
    string tool = Console.ReadLine();
    if (tool == "Lockpick")
    {
        Console.WriteLine("You have opened the treasure chest with your lockpick! You have found a map to the exit.");
    }
    else if (tool == "Magic")
    {
        Console.WriteLine("You have opened the treasure chest with your magic! You have found a teleportation scroll to the exit.");
    }
    else if (tool == "Arrow")
    {
        Console.WriteLine("You have opened the treasure chest with your arrow! You have found a compass to the exit.");
    }
    else
    {
        Console.WriteLine("You have chosen an invalid lockpicking tool. You have triggered a trap.");
    }
}
else
{
    Console.WriteLine("You have chosen an invalid path. You are lost in the forest.");
}

Console.ReadKey();
