public class Program
{
    public static void Main()
    {
        MyClass myclass = new MyClass("test string");
        Console.WriteLine(myclass.CurrentTarget);
    }
}

public class MyClass
{
    string m_CurrentTargetCharacterData;
    public string CurrentTarget => m_CurrentTargetCharacterData;
    public MyClass(string s)
    {
        m_CurrentTargetCharacterData = s;
    }

}