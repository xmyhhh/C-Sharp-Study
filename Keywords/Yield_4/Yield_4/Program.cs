

public class Gennerator
{
    static int num;
    static int k;
    public static IEnumerator<int> GetNumbers(int _num,int _k)  //yield return 也可以构成IEnumerator
    {
        num = _num;
        k= _k;
        int counter = 0;
        while (counter+k<num)
        {
            counter += k;
                yield return counter;
        }
    }
}


public class Program
{
    static void Main()
    {
        int num = (int)MathF.Pow(10,8);
        int k = 16141;
        var iterator = Gennerator.GetNumbers(num,k);
       
        while(iterator.MoveNext())
                Console.WriteLine(iterator.Current);
    }
}
