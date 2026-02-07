using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            char operation;
            bool validOperation = false;

            do
            {
                Console.Write("Choose operation (+,-,*,/,%,=): ");
                operation = Convert.ToChar(Console.ReadLine());

                if ("+-*/%=".Contains(operation))
                {
                    validOperation = true;
                }
                else
                {
                    Console.WriteLine("\nIncorrect Operation Used, please try again\n");
                }

            } while (!validOperation);

            double? result = Calculator(num1, num2, operation, ref isRunning);

            if (result != null && isRunning)
            {
                if (operation == '/')
                    Console.WriteLine("\nResult: " + result.Value.ToString("0.00"));
                else
                    Console.WriteLine("\nResult: " + result);
            }

            Console.WriteLine();
        }

        Console.WriteLine("Program terminated.");
    }
