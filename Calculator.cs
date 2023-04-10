using System;

namespace SimpleCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;

            Console.WriteLine("Welcome to Simple Calculator!");

            Console.Write("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /): ");
            op = char.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
