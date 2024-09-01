using System;

class BasicCalculator
{
    static void Main()
    {
        Console.WriteLine("Basic Calculator in C#");
        Console.WriteLine("-----------------------");

        // Input: Numbers
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Input: Operator
        Console.WriteLine("Choose an operator (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();  // For newline after operator input

        double result = 0;

        // Perform the chosen operation
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid operator. Please choose +, -, *, or /.");
                break;
        }
    }
}
