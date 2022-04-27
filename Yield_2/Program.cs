

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
        var primeNumber = Gennerator.GetPrimeNumbers().Take(100);//要多少，生成多少
        foreach(int prime in primeNumber)
        {
            Console.WriteLine(prime);
        }
    }
}
