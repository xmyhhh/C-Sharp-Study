## 什么是反射（Reflection）
* 反射指程序可以访问、检测和修改它本身状态或行为的一种能力
* 反射提供描述程序集、模块和类型的对象

下面一个简单的反射示例，使用方法 GetType()（被 Object 基类的所有类型继承）以获取变量类型：

```csharp
int i = 42;
Type type = i.GetType();
Console.WriteLine(type);
```