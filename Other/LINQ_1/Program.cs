


public class Program
{


    public static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        var b = a.GroupBy(x => x >= 3);

        foreach(var item in b)
        {
            Console.WriteLine(item.Key);
        }

    }
}