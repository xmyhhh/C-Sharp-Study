
public static class MyExtensions1
{
    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' },
                         StringSplitOptions.RemoveEmptyEntries).Length;
    }



    public static void Main()
    {
        string s = "Hello Extension Methods";
        int i = s.WordCount();
        Console.WriteLine(i);   
    }
}

