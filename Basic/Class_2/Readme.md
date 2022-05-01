# Class
继承和多态 - 基类/派生类转换规则、超级父类

## 基类/派生类转换规则
* 第一条准则：如果两个类是父子关系，那么在父类引用中保存子类类型总是安全的（派生类转父类总是安全的）
* 第二条准则：可以使用C#中的强制转换操作符进行显示的向下转换，显式强制转换是在运行时而不是编译时
## Example
### Convert derived class to base class 
```csharp
class Program
{
    static void Main()
    {
        Console.WriteLine("------------");
        ShopNPC shopNPC = new ShopNPC("item1", "shop1");
        shopNPC.AskName();
        shopNPC.Sale();
        Console.WriteLine("------------");
        NPC NPC = new ShopNPC("item2", "shop2"); //应用准则1，隐式转换
        NPC.AskName();
        //NPC.Sale();   无法调用
        ShopNPC shopNPC2 = (ShopNPC)NPC;
        shopNPC2.Sale(); //应用准则2，可以调用
    }
}
class NPC
{
    protected string name = "";
    public string Name
    {
        get => name;
        set => name = value;
    }

    public void AskName()
    {
        Console.WriteLine($"NPC tell you his name:{Name}");
    }
    public NPC(string m_name) => Name = m_name;
}

class ShopNPC : NPC
{

    private string item = "";
    public string Item
    {
        get => item;

        set => item = value;
    }
    public ShopNPC(string m_item, string m_name) : base(m_name)
    {
        item = m_item;
    }
    public void Sale()
    {
        Console.WriteLine($"shop:{Name} sale you item:{Item}");
    }

}
```
### Convert derived class to base class using `as`