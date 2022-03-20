namespace DelegatesActionFunc;

public class DelegateExample
{
    public delegate string OperationDelegate(int x, int y);
    
    public string ConvertTwoNumbersToString(OperationDelegate delegate1,int x, int y)
    {
        return delegate1(x, y);
        //Or return delegate1.Invoke(x, y);
    }
}