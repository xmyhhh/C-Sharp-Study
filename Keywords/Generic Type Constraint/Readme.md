# Generic Type Constraint
约束类型包括基类约束、构造函数约束、接口约束、参数约束等

```csharp
public class FateherTest
{
}
//where的用法 接口约束IComparable 和构造函数约束new(), 基类约束 FatherTest
public class TestA<T> where T : FateherTest, IComparable, new()
{
}
 
public class TestB
{
 //限制传递参数的类型必须继承IComparable 参数类型约束
    public int Caculate<T>(T t) where T : IComparable
    {
        throw new NotImplementedException();
    }
}
```