

public class Gennerator
{
    public static IEnumerator<int> GetPrimeNumbers()  //yield return 也可以构成IEnumerator
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

        var iterator = Gennerator.GetPrimeNumbers();
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



        Console.WriteLine("------- foreach (int i in iterator)--------");
        //foreach (int i in iterator)    //foreach 不能用于IEnumerator
        //{
        //    Console.WriteLine(i);
        //}
    }
}
