static class Program
{
    public delegate void OperationDelegate();
    public static void Main(string[] args)
    {
        OperationDelegate? d=null;
        d += Process1;
        d += Process2;
        
        d.Invoke();
    }

    public static void Process1()
    {
        Console.WriteLine("Inside delegate 1");
        
    }

    public static void Process2()
    {
        Console.WriteLine("Inside delegate 2");
        
    }
}