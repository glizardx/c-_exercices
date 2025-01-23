using System;

namespace Coding.Exercise
{
    public class Program
    {
        static int baseLength = 12;
        static int height = 6;

        static Triangle calc = new Triangle(baseLength, height);

        public static void Main(string[] args)
        {
            Console.WriteLine($"Base is {calc.Base}, height is {calc.Height}");
        }
    }

    public class Triangle
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public Triangle(int baseLength, int height)
        {
            Base = baseLength;
            Height = height;
        }

        public int CalculateArea()
        {
            return (Base * Height) / 2;
        }

        public string AsString()
        {
            return $"Base is {Base}, height is {Height}";
        }
    }
}
