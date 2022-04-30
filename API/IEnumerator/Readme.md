# IEnumerable
The IEnumerable interface is the base Interface for many collections in C#, 
and its job is to provide a way of iteration through a collection. That is why we can use for each loops to go through a List or a Dictionary. 
In simple English when a collection class implements the IEnumerable interface it becomes countable, and we can count each element in it individually

There are 2 versions of the IEnumerable Interface

### generic collections: can store any type of objects
* IEnumerable in System.Collections
### non-generic collections
* IEnumerable <T> in System.Collections.Generic

**It is no longer recommended to use the non-generic collections in a new project
due to their need to perform boxing and unboxing (converting the types of objects)**


## Making your Classes Enumerable 
IEnumerable<T> contains a single method that you must implement when implementing this interface;
GetEnumerator(), which returns an IEnumerator<T> object


## IEnumerator
* IEnumerator object具体实现了iterator（通过MoveNext()，Reset()，Current）
* IEnumerator只允许读取集合中的数据。枚举数无法用于修改基础集合
* 最初，枚举数被定位于集合中第一个元素的前面。Reset   也将枚举数返回到此位置。在此位置，调用   Current   会引发异常。因此，在读取   Current   的值之前，必须调用   MoveNext   将枚举数提前到集合的第一个元素。  
   
* 在调用   MoveNext   或   Reset   之前，Current   返回同一对象。MoveNext   将   Current   设置为下一个元素

## IEnumerable vs IEnumerator
* 一个Collection要支持foreach方式的遍历，必须实现GetEnumerator()接口返回IEnumerator
* IEnumerable声明该class是“可枚举（enumerable）”的，但并没有说明如何实现枚举器（iterator）
* IEnumerator是一个实现式的接口，IEnumerator object就是一个iterator



## Reference
[tutorials](https://www.youtube.com/watch?v=VcAubtFBOdY)