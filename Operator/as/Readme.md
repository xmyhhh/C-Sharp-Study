# as operator
The as operator explicitly converts the result of an expression to a given reference or nullable value type. If the conversion isn't possible, the as operator returns null. 
Unlike a cast expression(强制转换), the as operator never throws an exception.（转换失败等于null）
## Example
```csharp
Circle c1 = p1 as Circle;

if (c1 == null)
{

    Console.WriteLine("出错了，p1不是圆");

}
```