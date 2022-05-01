// See https://aka.ms/new-console-template for more information
public interface IMyInterface
{
    //private void TetsFunction(); //不能写private，也不能写实现，最新的c#语法似乎支持写默认实现，但unity还不支持
    // static void TetsFunction();  //不能用static修饰
    void TetsFunction();   //可以写方法声明

    int a { get; set; }  //可以写属性声明

    //float b;   不能写字段声明
}

public class MyClass : IMyInterface
{
    public int a { get; set; }    //必须声明为public
    public void TetsFunction()   //必须声明为public
    {
        Console.WriteLine("TetsFunction");
    }

    public static void Main()
    {
        MyClass myClass = new MyClass();
        myClass.TetsFunction();
    }
}


public struct MySruct : IMyInterface
{
    public int a { get; set; }    //必须声明为public
    public void TetsFunction()   //必须声明为public
    {
        Console.WriteLine("TetsFunction");
    }
}