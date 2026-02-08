using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            int first = ReadInt("Enter first number: ");
            int second = ReadInt("Enter second number: ");

            string operation = ReadOperation();

            if (operation == "=")
            {
                running = false;
                continue;
            }

            double? result = Calculator.Calculate(first, second, operation);

            if (result == null && (operation == "/" || operation == "%") && second == 0)
                Console.WriteLine("Cannot divide or modulo by zero");
            else
                Console.WriteLine($"Result: {Math.Round(result.Value, 2)}");

            Console.WriteLine();
        }

        Console.WriteLine("Program terminated.");
    }

    static int ReadInt(string message)
    {
        int number;
        while (!int.TryParse(Read(message), out number))
            Console.WriteLine("Invalid input. Please enter a whole number.");
        return number;
    }

    static string ReadOperation()
    {
        while (true)
        {
            Console.Write("Choose operation (+, -, *, /, %, =): ");
            string op = Console.ReadLine();
            if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%" || op == "=")
                return op;
            Console.WriteLine("Incorrect operation. Try again.");
        }
    }

    static string Read(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
}
