public class Program
{
    static void Main()
    {
        MyClass_2 myClass = new MyClass_2();
        Console.WriteLine(myClass.stats.a);

        myClass.stats.a = 1;
        Console.WriteLine(myClass.stats.a);
    }


}

public class MyClass_1
{
    public Stats stats { get; set; } = new Stats();
}
public class MyClass_2
{
    public Stats stats
    {
        get
        {
            return m_stats;
        }
        set
        {
            m_stats = value;
        }
    }

    Stats m_stats = new Stats();
}

public class Stats
{
    public int a = 0;
}