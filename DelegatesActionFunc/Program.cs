// See https://aka.ms/new-console-template for more information



namespace DelegatesActionFunc;

static class Program
{


    public static void Main(string[] args)
    {
        DelegateExample delegateExample = new DelegateExample();
        var response=delegateExample.ConvertTwoNumbersToString(ProcessRequest, 20, 30);

        Console.WriteLine(response);
    }

    private static string ProcessRequest(int x, int y)
    {
        return $"int x= {x}, int y={y}";
    }
}