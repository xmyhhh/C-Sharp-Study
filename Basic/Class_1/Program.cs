class Program
{
    static void Main()
    {
        ShopNPC shopNPC = new ShopNPC("item1", "shop1");
        shopNPC.AskName();
        shopNPC.Sale();
        shopNPC.Move("place1");
    }
}


class NPC
{
    protected string name = "";
    public string Name
    {
        get => name;
        set => name = value;
    }
    public void AskName()
    {
        Console.WriteLine($"NPC tell you his name:{Name}");
    }
    public NPC(string m_name) => Name = m_name;
}
interface IShop
{
    void Sale();
}
interface IPlace
{
    void Move(string place);
}
class ShopNPC : NPC, IShop, IPlace
{

    private string item = "";
    public string Item
    {
        get => item;

        set => item = value;
    }
    public ShopNPC(string m_item, string m_name) : base(m_name)
    {
        item = m_item;
    }
    public void Sale()
    {
        Console.WriteLine($"shop:{Name} sale you item:{Item}");
    }
    public void Move(string place)
    {
        Console.WriteLine($"shop:{Name} move t place:{place}");
    }
}