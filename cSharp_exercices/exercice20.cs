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

            bool continua = true;
            while (continua)
            {
                Menu(calculator);
                Console.WriteLine("Do you want to continue? (y/n)");
                continua = Console.ReadLine().ToLower() == "y";
            }
        }

        static void Menu(Calculator calculator)
        {
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Console.WriteLine($"The sum operation is: {Sum(calculator)}");
                    break;
                case 2:
                    Console.WriteLine($"The subtraction operation is: {Subtract(calculator)}");
                    break;
                case 3:
                    Console.WriteLine($"The multiplication is: {Multiply(calculator)}");
                    break;
                case 4:
                    Console.WriteLine($"The division is: {Divide(calculator)}");
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
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
