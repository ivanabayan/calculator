static double? Calculator(int a, int b, char op, ref bool isRunning)
    {
        switch (op)
        {
            case '+':
                return a + b;

            case '-':
                return a - b;

            case '*':
                return a * b;

            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return null;
                }
                return (double)a / b;

            case '%':
                if (b == 0)
                {
                    Console.WriteLine("Cannot modulo by zero");
                    return null;
                }
                return a % b;

            case '=':
                isRunning = false;
                return null;

            default:
                return null;
        }
    }
}
