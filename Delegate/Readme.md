## 委托（Delegate）
### 什么是 Delegate
C# 中的委托（Delegate）类似于 C 或 C++ 中函数的指针。委托（Delegate） 是存有对某个方法的引用的一种引用类型变量。引用可在运行时被改变

委托（Delegate）特别用于实现事件和回调方法。所有的委托（Delegate）都派生自 System.Delegate 类

### 委托的多播（Multicasting of a Delegate）
委托对象可使用 "+" 运算符进行合并。一个合并委托调用它所合并的两个委托。只有相同类型的委托可被合并。"-" 运算符可用于从合并的委托中移除组件委托。

使用委托的这个有用的特点，您可以创建一个委托被调用时要调用的方法的调用列表。这被称为委托的 多播（multicasting），也叫组播。

### 内置的 Action 委托和 Func 委托
一般情况下，不需要自己定义委托，利用内置的 Action 和 Func 即可
* Action 委托只能有输入
* Func 委托可以有输入和输出