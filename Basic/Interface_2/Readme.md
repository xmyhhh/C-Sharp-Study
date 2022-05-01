# Interface_2

使用interface实现类似于c++多继承的效果

## 案例
假如你有一个类叫老虎，还有一个类叫苍蝇。现在你想新创一个超级老虎类，一种可以飞的老虎。在C++中，你可以定义一种超级老虎类，让其继承自老虎和苍蝇，这样这种老虎就可以飞了。然而，问题出现了，这种超级老虎由于同时也继承自苍蝇，而苍蝇下面有个方法叫吃，参数类型是屎。吃屎的这个方法显然跟我们的超级老虎太不搭了。

虽然这个例子有些夸张，但是很多C++程序员真的就是这样在设计代码。由于子类继承了多个父类，而多个父类肯定有些成员跟这个子类不搭调，于是子类的调用者就很难受了。比如上面这个例子，当调用者拿到超级老虎的一个实例时，发现超级老虎下面怎么会有个吃屎的方法呢！！！真的是要笑死人了。

C++要这样允许多继承就必然会造成这个问题。C#程序员就绝对不会写出这样滑稽的代码。对于C#程序员，肯定是要把这个飞的方法提成接口的，然后让苍蝇类和超级老虎类都继承自这个接口。这样，苍蝇会飞，超级老虎也会飞。是不是完美解决这个问题？

问题看上去解决了，但是，假如我跟你说苍蝇飞的方法跟超级老虎飞的方法需要一模一样：首先张开双翅，身体前倾，拍打双翅，起飞，继续拍打。我们肯定不能把同一份代码copy一份吧，那是属于入门级程序员干的事，我们现在已经没资格干那事了。那怎么办呢？简单快速的做法是使用静态方法，比如FlyHelper.Fly(...)。

静态方法解决了代码重用的问题，但写起来始终觉得哪里不对劲。我的超级老虎类和苍蝇都明明继承了飞了啊，为什么还要这样调用一句静态方法。如果以后哪天我想让我的猪也能飞起来，那岂不是还要来调用这个静态方法。

到底怎样才能在C#中实现像C++那样优雅的继承呢？


```csharp
namespace Interface
{
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
}
```
```csharp
namespace Interface
{
    //苍蝇类实现飞的接口
    public class flies : IFly
    {
        public void fly()
        {
            //调用接口中飞的方法
            this.StartFly();
        }
    }
}
```
```csharp
namespace Interface
{
    //老虎类
    public class Tiger
    {
        public void introduce()
        {
            Console.WriteLine("I am a tiger");
        }
    }
}
```
```csharp
namespace Interface
{
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
}
```
## Reference

[csdn](https://blog.csdn.net/zhanghongjie0302/article/details/38875865)