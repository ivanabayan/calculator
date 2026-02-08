public static class Calculator
{
    public static double? Calculate(int first, int second, string operation)
    {
        switch (operation)
        {
            case "+":
                return first + second;
            case "-":
                return first - second;
            case "*":
                return first * second;
            case "/":
                if (second == 0) return null;
                return (double)first / second;
            case "%":
                if (second == 0) return null;
                return first % second;
            default:
                return null;
        }
    }
}
