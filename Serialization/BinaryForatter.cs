//二进制序列化与反序列化
using System;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]  //必须添加序列化特性
public class Person
{
    private string Name;//姓名
    private bool Sex;//性别，是否是男
    public Person(string name, bool sex)
    {
        this.Name = name;
        this.Sex = sex;
    }
    public override string ToString()
    {
        return "姓名：" + this.Name + "\t性别：" + (this.Sex ? "男" : "女");
    }
}
[Serializable]  //必须添加序列化特性
public class Programmer : Person
{
    private string Language;//编程语言
    public Programmer(string name, bool sex, string language) : base(name, sex)
    {
        this.Language = language;
    }
    public override string ToString()
    {
        return base.ToString() + "\t编程语言：" + this.Language;
    }
}
class Program
{
    static void Main(string[] args)
    {
        //创建Programmer列表，并添加对象
        List<Programmer> list = new List<Programmer>();
        list.Add(new Programmer("李志伟", true, "C#"));
        list.Add(new Programmer("Coder2", false, "C++"));
        list.Add(new Programmer("Coder3", true, "Java"));
        //使用二进制序列化对象
        string fileName = @".\Programmers.dat";//文件名称与路径
        Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
        BinaryFormatter binFormat = new BinaryFormatter();//创建二进制序列化器
        binFormat.Serialize(fStream, list);
        //使用二进制反序列化对象
        list.Clear();//清空列表
        fStream.Position = 0;//重置流位置
        list = (List<Programmer>)binFormat.Deserialize(fStream);//反序列化对象
        foreach (Programmer p in list)
        {
            Console.WriteLine(p);
        }
        Console.Read();
    }

}

