public class Program
{
    public delegate void Del(string message);  //定义委托类型（输入参数和返回参数）
    static void Main()
    {
        // Instantiate the delegate.
        Del handler = DelegateMethod;

        // Call the delegate.
        handler("Hello World");
    }

    // Create a method for a delegate.
    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

}