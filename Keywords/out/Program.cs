public class Program
{
    static void Main()
    {

        string C;
        Get(out C);

        Console.WriteLine($"C:{C} ");
    }
    //方法体
    public static int Get(out string name)
    {
        name = "123213";
        return 0;//返回前给out参数赋值
    }

}