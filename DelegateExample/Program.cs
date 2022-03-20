namespace DelegateExample;

internal static class Program
{
    private delegate int OperationDelegate(int x,int y);

    public static void Main()
    {
        Console.WriteLine("Enter first number");
        var firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number");
        var secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select one: add, subtract, multiply");
        var operation = Console.ReadLine();

        OperationDelegate? calculator = null;

        switch (operation)
        {
            case "add":
                calculator = (x, y) => x + y;
                break;
            case "subtract":
                calculator = (x, y) => x - y;
                break;
            case "multiply":
                calculator = (x, y) => x * y;
                break;
            default:
                calculator = (x, y) => x + y;
                break;
        }

        ProcessData(firstNumber, secondNumber, calculator);
    }

    private static void ProcessData(int firstNumber, int secondNumber, OperationDelegate? calculator)
    {
        var result = calculator!(firstNumber, secondNumber);
        Console.WriteLine(result);
    }
}