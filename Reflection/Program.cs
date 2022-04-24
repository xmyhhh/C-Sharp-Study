// See https://aka.ms/new-console-template for more information
using System.Reflection;



public class Person
{

    private int age;

    public int Age
    {

        get
        {

            return age;
        }

        set
        {

            age = value;
        }
    }

    public void SaySomething()
    {

        Console.WriteLine("Hello World");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Person);

        //字段
        PropertyInfo[] propertyInfos = type.GetProperties();

        //属性
        FieldInfo[] fieldInfos = type.GetFields();

        //方法
        MethodInfo[] methodInfos = type.GetMethods();


        foreach (FieldInfo fieldInfo in fieldInfos)
        {

            Console.WriteLine($"【字段】：{fieldInfo.Name}");
        }

        foreach (PropertyInfo propertyInfo in propertyInfos)
        {

            Console.WriteLine($"【属性】：{propertyInfo.Name}");
        }

        foreach (MethodInfo methodInfo in methodInfos)
        {

            Console.WriteLine($"【方法】：{methodInfo.Name}");
        }

    }
}
