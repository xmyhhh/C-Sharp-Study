static class StaticClassExample
{
    public static void DoSomething()
    {
        Console.WriteLine("DoSomething");
    }
    public static void DoSomethingElse()
    {
        Console.WriteLine("DoSomethingElse");
    }

}


class StaticClassMemberExample
{
    public static void DoSomethingStatic()
    {
        Console.WriteLine("DoSomethingStatic");
    }

    public void DoSomething()
    {
        Console.WriteLine("DoSomething");
    }

    public static int y = 5;

    public void print_y()
    {
        Console.WriteLine(y);
    }
    public void add_y()
    {
        y = y + 1;
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("------------");
        StaticClassExample.DoSomething();
        StaticClassExample.DoSomethingElse();

        Console.WriteLine("------------");
        StaticClassMemberExample.DoSomethingStatic();
        new StaticClassMemberExample().DoSomething();

        Console.WriteLine("------------");
        StaticClassMemberExample staticClassMemberExample_1 = new StaticClassMemberExample();
        StaticClassMemberExample staticClassMemberExample_2 = new StaticClassMemberExample();
        Console.WriteLine("before add");
        staticClassMemberExample_1.print_y();
        staticClassMemberExample_2.print_y();
        staticClassMemberExample_1.add_y();
        Console.WriteLine("after add");
        staticClassMemberExample_1.print_y();
        staticClassMemberExample_2.print_y();
    }
}

