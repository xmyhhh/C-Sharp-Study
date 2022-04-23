## 什么是特性（Atrribute）
首先，我们肯定Attribute是一个类，下面是msdn文档对它的描述：

`公共语言运行时允许你添加类似关键字的描述声明，叫做Atrribute, 它对程序中的元素进行标注，如类型、字段、方法和属性等。
使用Atrribute，可以有效地将元数据或声明性信息与代码（程序集、类型、方法、属性等）相关联。 将Atrribute与程序实体相关联后，可以在运行时使用反射这项技术查询特性。`

特性具有以下属性：
* Atrribute向程序添加元数据。 元数据是程序中定义的类型的相关信息。 所有 .NET 程序集都包含一组指定的元数据，用于描述程序集中定义的类型和类型成员。 可以添加自定义特性来指定所需的其他任何信息。 有关详细信息，请参阅创建自定义特性 (C#)。
* 可以将一个或多个Atrribute应用于整个程序集、模块或较小的程序元素（如类和属性）。
* Atrribute可以像方法和属性一样接受自变量。
* 程序可使用反射来检查自己的元数据或其他程序中的元数据。
## Attribute 类
我们可以自定义我们自己的Attribute，所有自定义的Attribute必须从Attribute类派生。

#### 三个静态方法
static Attribute GetCustomAttribute():这个方法有8种重载的版本，它被用来取出施加在类成员上指定类型的Attribute。

static Attribute[] GetCustomAttributes(): 这个方法有16种重载版本，用来取出施加在类成员上指定类型的Attribute数组。

static bool IsDefined():由八种重载版本，看是否指定类型的定制attribute被施加到类的成员上面
#### 实例方法
bool IsDefaultAttribute(): 如果Attribute的值是默认的值，那么返回true。

bool Match():表明这个Attribute实例是否等于一个指定的对象。
#### 公共属性
TypeId: 得到一个唯一的标识，这个标识被用来区分同一个Attribute的不同实例


## Attribute 的定义
对于一个自定义的Attribute，你可以通过AttributeUsage来限定你的Attribute 所施加的元素的类型。例如下面的写法：

```csharp
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false ]
```
* AttributeTarges: 的值允许通过“或”操作来进行多个值得组合，如果你没有指定参数，那么默认参数就是All（All = Assembly | Module | Class | Struct | Enum | Constructor | Method | Property | Field | Event | Interface | Parameter | Delegate）

* AllowMultiple: 读取或者设置这个属性，表示是否可以对一个程序元素施加多个Attribute 

* Inherited:读取或者设置这个属性，表示是否施加的Attribute 可以被派生类继承或者重载

* ValidOn: 读取或者设置这个属性，指明Attribute 可以被施加的元素的类型


## Attribute 的常见用途
* 在 Web 服务中使用 WebMethod 特性标记方法，以指明方法应可通过 SOAP 协议进行调用。 有关详细信息，请参阅 WebMethodAttribute。
* 描述在与本机代码互操作时如何封送方法参数。 有关详细信息，请参阅 MarshalAsAttribute。
* 描述类、方法和接口的 COM 属性。
* 使用 DllImportAttribute 类调用非托管代码。
* 从标题、版本、说明或商标方面描述程序集。
* 描述要序列化并暂留类的哪些成员。
* 描述如何为了执行 XML 序列化在类成员和 XML 节点之间进行映射。
* 描述的方法的安全要求。
* 指定用于强制实施安全规范的特征。
* 通过实时 (JIT) 编译器控制优化，这样代码就一直都易于调试。
* 获取方法调用方的相关信息。


## 使用反射访问 Attribute
通过使用反射，可以检索通过自定义特性定义的信息。 主要方法是 GetCustomAttributes，它返回对象数组，这些对象在运行时等效于源代码特性。

在MSDN的[举例](https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/concepts/attributes/accessing-attributes-by-using-reflection#example)中
对 SampleClass 调用 GetCustomAttributes 会导致按上述方式构造并初始化一个 Author 对象。 如果该类具有其他特性，则将以类似方式构造其他特性对象。 
然后 GetCustomAttributes 会以数组形式返回 Author 对象和任何其他特性对象。 之后你便可以循环访问此数组，根据每个数组元素的类型确定所应用的特性，并从特性对象中提取信息。