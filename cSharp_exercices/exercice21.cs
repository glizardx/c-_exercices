using System;
using System.Data;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Seconds");
            Console.WriteLine("M = Minutes");
            Console.WriteLine("How long do you want the timer to run?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;
            
            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }
            
            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go!");
            Thread.Sleep(2500);
            
            Start(time);
        }
        
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime++;
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Time's up!");
            Thread.Sleep(2500);
            Menu();

        }
    }
}
