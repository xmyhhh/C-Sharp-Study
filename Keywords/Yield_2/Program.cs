

public class Gennerator
{
    public static IEnumerable<int> GetPrimeNumbers()
    {
        int counter = 0;
        while (true)
        {

            if (IsPrimeNumber(counter))
            {
                yield return counter;
            }


            counter++;
        }
    }


    private static bool IsPrimeNumber(int value)
    {


        for (int i = 2; i <= value / 2; i++)
        {
            if (value % i == 0)
            {
                return false;
            }
        }
        return true;
    }


}


public class Program
{
    static void Main()
    {
        var primeNumber0 = Gennerator.GetPrimeNumbers().Take(10).ToList(); //Take返回一个可迭代对象子对象转换成list



        var primeNumber1 = Gennerator.GetPrimeNumbers().Take(10);
        foreach (int prime in primeNumber1)
        {
            Console.WriteLine(prime);
        }
        Console.WriteLine("-------Gennerator.GetPrimeNumbers().Take(10)--------");

        var primeNumber2 = Gennerator.GetPrimeNumbers().Take(10);//take会重头开始
        foreach (int prime in primeNumber2)
        {
            Console.WriteLine(prime);
        }

        Console.WriteLine("-------Gennerator.GetPrimeNumbers().Take(10)--------");
        var iterator = Gennerator.GetPrimeNumbers().GetEnumerator();

        for (int i = 0; i < 10; i++)
        {
            if (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            else
            {
                break;  //如果可迭代对象没有下一个，就退出
            }
        }
        Console.WriteLine("-------Gennerator.GetPrimeNumbers().GetEnumerator();--------");
        for (int i = 0; i < 10; i++)
        {
            if (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            else
            {
                break;  //如果可迭代对象没有下一个，就退出
            }
        }
        Console.WriteLine("-------Gennerator.GetPrimeNumbers().GetEnumerator();--------");
    }
}
