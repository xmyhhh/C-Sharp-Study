
//飞的接口 
public interface IFly
{
}
//扩展方法
public static class ExtendFly
{
    public static void StartFly<T>(this T example) where T : IFly
    {
        Console.WriteLine("准备");
        Console.WriteLine("张开双翅");
        Console.WriteLine("起飞");
        Console.WriteLine("我飞，我飞，我飞飞飞");
    }
}


//苍蝇类实现飞的接口
public class flies : IFly
{
    public void fly()
    {
        //调用接口中飞的方法
        this.StartFly();
    }
}


//老虎类
public class Tiger
{
    virtual public void introduce()
    {
        Console.WriteLine("I am a tiger");
    }
}


//超级老虎类，继承了老虎类，并实现了飞的方法
public class SuperTiger : Tiger, IFly
{
    public override void introduce()
    {
        Console.WriteLine("大家好，我是超级老虎哦！");
    }

    public void TigerFly()
    {
        //调用接口中飞的方法
        this.StartFly();
    }
}



class Program
{
    static void Main()
    {
        SuperTiger superTiger = new SuperTiger();
        superTiger.TigerFly();
    }
}