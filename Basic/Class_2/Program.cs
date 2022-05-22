class Program
{
    static void Main()
    {
        Console.WriteLine("------------");
        ShopNPC shopNPC = new ShopNPC("item1", "shop1");
        shopNPC.AskName();
        shopNPC.Sale();


        Console.WriteLine("------------");
        NPC NPC = new ShopNPC("item2", "shop2");
        NPC.AskName();
        //NPC.Sale();   无法调用
        ShopNPC shopNPC2 = (ShopNPC)NPC;
        shopNPC2.Sale(); //可以调用
        shopNPC2.AskName();
        NPC NPC2 = (NPC)shopNPC2;
        NPC2.AskName();

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

    public virtual void AskName()
    {
        Console.WriteLine($"NPC tell you his name:{Name}");
    }
    public NPC(string m_name) => Name = m_name;
}

class ShopNPC : NPC
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
    public override void AskName()
    {
        Console.WriteLine($"ShopNPC tell you his name:{Name}");
    }
    public void Sale()
    {
        Console.WriteLine($"shop:{Name} sale you item:{Item}");
    }

}