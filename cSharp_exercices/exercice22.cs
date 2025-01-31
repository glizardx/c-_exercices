using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 10, -2, 3, 4, 5 }; // Contém um número negativo (-2)

        Calculator calculator = new Calculator();

        var sum = calculator.CalculateSum(numbers);
        var product = calculator.CalculateProduct(numbers);
        var subtraction = calculator.CalculateSubtraction(numbers);

        Console.WriteLine("Soma: " + sum);
        Console.WriteLine("Multiplicação: " + product);
        Console.WriteLine("Subtração: " + subtraction);

        Console.ReadKey();
    }
}

public class Calculator
{
    private List<int> FilterPositiveNumbers(List<int> numbers)
    {
        return numbers.Where(n => n > 0).ToList(); // Retorna apenas números positivos.
    }

    public int CalculateSum(List<int> numbers)
    {
        numbers = FilterPositiveNumbers(numbers); // Filtra números positivos.

        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    public virtual int CalculateProduct(List<int> numbers)
    {
        numbers = FilterPositiveNumbers(numbers); // Filtra números positivos.

        if (numbers.Count == 0)
            return 0; // Retorna 0 se não houver números positivos.

        int product = 1;
        foreach (var number in numbers)
        {
            product *= number;
        }
        return product;
    }

    public virtual int CalculateSubtraction(List<int> numbers)
    {
        numbers = FilterPositiveNumbers(numbers); // Filtra números positivos.

        if (numbers.Count == 0)
            return 0; // Retorna 0 se não houver números positivos.

        int subtraction = numbers[0]; // Começa com o primeiro número positivo.

        for (int i = 1; i < numbers.Count; i++)
        {
            subtraction -= numbers[i];
        }

        return subtraction;
    }
}
