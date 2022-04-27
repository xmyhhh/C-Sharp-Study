# IEnumerable
## What is IEnumerable

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




## Reference
[tutorials](https://www.youtube.com/watch?v=VcAubtFBOdY)