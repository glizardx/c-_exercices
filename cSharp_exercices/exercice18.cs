using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = GetDoubleInput("Enter the first number: ");
            double number2 = GetDoubleInput("Enter the second number: ");
            
            Calculator calculator = new Calculator(number1, number2);
            Console.WriteLine(calculator);
            
            Console.WriteLine($"Sum: {Sum(calculator)}");
            Console.WriteLine($"Subtract: {Subtract(calculator)}");
            Console.WriteLine($"Multiply: {Multiply(calculator)}");
            Console.WriteLine($"Divide: {Divide(calculator)}");
        }

        static double GetDoubleInput(string prompt)
        {
            Console.WriteLine(prompt);
            double result;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid double.");
            }
            return result;
        }
        
        static double Sum(Calculator calculator)
        {
            return calculator.Number1 + calculator.Number2;
        }
        
        static double Subtract(Calculator calculator)
        {
            return calculator.Number1 - calculator.Number2;
        }
        
        static double Multiply(Calculator calculator)
        {
            return calculator.Number1 * calculator.Number2;
        }
        
        static double Divide(Calculator calculator)
        {
            return calculator.Number1 / calculator.Number2;
        }
    }

    struct Calculator
    {
        public Calculator(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public override string ToString()
        {
            return $"Number1: {Number1}, Number2: {Number2}";
        }
    }
}
