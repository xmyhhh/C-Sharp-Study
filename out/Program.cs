public class Program
{
    static void Main()
    {
        int A, B;
        A = 1;
        string C;
        Get(A, out B, out C);

        Console.WriteLine($"A{A},B{B},C{C} ");
    }
    //方法体
    public static int Get(int i, out int x, out string name)
    {
        x = 0;
        name = "";
        return i;//返回前给out参数赋值
    }

}