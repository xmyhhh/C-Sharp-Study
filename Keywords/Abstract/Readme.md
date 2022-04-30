# Abstract 
The abstract keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.
## Abstract 修饰类(抽象类)
### 特点

* An abstract class cannot be instantiated.（抽象类不能直接实例化）

* An abstract class may contain abstract methods and accessors.（抽象类可以包含抽象方法、属性、索引器、事件，也可以包含非抽象成员）

* It is not possible to modify an abstract class with the sealed modifier because the two modifiers have opposite meanings. The modifier prevents a class from being inherited and the modifier requires a class to be inherited.sealedabstract.（不能用sealed关键字修饰抽象类）

* A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.（派生自抽象类的类必须实现抽象类的所有抽象成员）



## Abstract 修饰方法（抽象方法）
### 特点
* An abstract method is implicitly a virtual method.
* 抽象方法在派生类中是必须用override来进行重写的
* Abstract method declarations are only permitted in abstract classes.(抽象方法声明只允许在抽象类中)
* It is an error to use the static or virtual modifiers in an abstract method declaration.
* An abstract inherited property can be overridden in a derived class by including a property declaration 
that uses the override modifier.(通过包含使用 override 修饰符的属性声明，可以在派生类中覆盖抽象继承属性。)

### Example
#### a. Abstract class with a abstract method
```csharp
abstract class Shape
{
    public abstract int GetArea();
}

class Square : Shape
{
    private int _side;

    public Square(int n) => _side = n;

    // GetArea method is required to avoid a compile-time error.
    public override int GetArea() => _side * _side;

    static void Main()
    {
        var sq = new Square(12);
        Console.WriteLine($"Area of the square = {sq.GetArea()}");
    }
}
// Output: Area of the square = 144
```

#### b. Abstract class inherits a virtual method from a base class
In this way, an abstract class can force derived classes to provide new method implementations for virtual methods
```csharp
public class D
{
    public virtual void DoWork(int i)
    {
        // Original implementation.
    }
}

public abstract class E : D
{
    public abstract override void DoWork(int i);
}

public class F : E
{
    public override void DoWork(int i)
    {
        // New implementation.
    }
}
```

#### c. An abstract class that implements an interface
An abstract class must provide implementation for all interface members. 

An abstract class that implements an interface might map the interface methods onto abstract methods.(把接口方法映射到抽象方法)
```csharp
interface I
{
    void M();
}

abstract class C : I
{
    public abstract void M();
}
```


## Reference
[MS Doc](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract)