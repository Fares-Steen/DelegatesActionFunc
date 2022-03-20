namespace ActionExample;

internal static class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter first number");
        var firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number");
        var secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select one: add, subtract, multiply");
        var operation = Console.ReadLine();

        Action<int,int> calculator = null;

        switch (operation)
        {
            case "add":
                calculator = (x, y) => Console.WriteLine( x + y);
                break;
            case "subtract":
                calculator = (x, y) => Console.WriteLine( x - y);
                break;
            case "multiply":
                calculator = (x, y) => Console.WriteLine( x * y);
                break;
            default:
                calculator = (x, y) => Console.WriteLine( x + y);
                break;
        }

        ProcessData(firstNumber, secondNumber, calculator);
    }

    private static void ProcessData(int firstNumber, int secondNumber, Action<int,int> action)
    {
        action(firstNumber, secondNumber);
        Console.WriteLine("action have been invoked");
    }
}