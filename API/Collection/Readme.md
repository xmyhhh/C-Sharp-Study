# Build-in Collections
## Build-in Non-Generic Collection
### ArrayList
ArrayList 只有非泛型
```csharp
int num1=5;
string name="Denis";

ArrayList muArrList=new ArrayList();

myArrList.Add(num1);
myArrList.Add(name);

foreach (object element in myArrList){
	//some code here
}

```

### Stack
### HashTable
### SortedList
### Queue
```csharp
Queue queue = new Queue();
queue.Enqueue(1);
queue.Enqueue("some string");
```
## Build-in Generic Collection
### List< T >
List只有泛型

```csharp
string animal1="cat";
string animal2="dog";
string animal3="pig";

List<string> myList =new List<string>();

myList.Add(animal1);
myList.Add(animal2);
myList.Add(animal3);


```

### Queue< T >
```csharp
 Queue<int> numberQueue = new Queue<int>();
        numberQueue.Enqueue(6);
        numberQueue.Enqueue(7);
```

### Dictionary<TKey,TValue>

### HashSet<T>


### Stack<T>
## Reference 


[System.Collections 命名空间](https://docs.microsoft.com/zh-cn/dotnet/api/system.collections?view=net-6.0)

[System.Collections.Generic 命名空间](https://docs.microsoft.com/zh-cn/dotnet/api/system.collections.generic?view=net-6.0)