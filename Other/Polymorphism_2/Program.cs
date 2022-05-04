class Program
{
    static void Main()
    {
        Cat c = new Cat();
        Dog d = new Dog();
        GetSwimming(c);
        GetSwimming(d);
    }

    //写一个方法，完成动物游泳（对象做参数）
    static void GetSwimming(Animal a)//a是引用
    {

        a.Swimming();
    }


}
class Animal
{
    public virtual void Swimming()
    {
        Console.WriteLine("动物游泳");
    }
}
class Cat : Animal
{
    public override void Swimming()
    {
        Console.WriteLine("猫游泳");
    }
}

class Dog : Animal
{
    public override void Swimming()
    {
        Console.WriteLine("狗游泳");
    }
}