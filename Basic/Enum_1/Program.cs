public enum DamageType
{
    Physical,
    Fire,
    Cold,
    Electric

}

public class Program
{
    public static void Main()
    {
        var a = Enum.GetValues(typeof(DamageType)); //检索指定枚举中常数值的数组
        var a_len = a.Length; //获取数组长度
        Console.WriteLine(a);

        foreach (int i in Enum.GetValues(typeof(DamageType)))
            Console.WriteLine(i);
    }

    //int[] elementalProtection = new int[Enum.GetValues(typeof(DamageType)).Length];
}

