# is operator
The is operator checks if the result of an expression is compatible with a given type. 
## Example
```csharp
static void GivePromotion(Employee e)
{
    if (e is Manager)
    {

        Console.WriteLine("我是经理,我的股票期权有{0}", ((Manager)e).StockOptions);
    }
    if (e is SalePerson)
    {

        Console.WriteLine("我是销售人员，我的销售额有{0}", ((SalePerson)e).SalesNumber);
    }
}
```