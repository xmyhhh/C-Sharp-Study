class Animal
{
    public virtual void call()
    {
        Console.WriteLine("无声的叫唤");
    }
}

class Dog : Animal
{

    public override void call()
    {
        Console.WriteLine("叫声：汪～汪～汪～");
    }
}


class Program
{
    static void Main()
    {
        Animal a = new Animal();

        a.call();

        Animal b = new Dog(); //转化后的父类对象具有父类所有方法，若方法被子类重写override，那么实际调用时，调用的是重写后的实现。
        b.call();

        Dog c = new Dog();
        c.call();
    }


}


