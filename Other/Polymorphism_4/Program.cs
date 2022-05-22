class Program
{
    static void Main()
    {

        DogGenerater dogGenerater = new DogGenerater();
        HumanGenerater humanGenerater = new HumanGenerater();
        Console.WriteLine("---restaurant---");

        Restaurant restaurant = new Restaurant();
        restaurant.AddCustomer(dogGenerater.Generate());
        restaurant.AddCustomer(humanGenerater.Generate());
        restaurant.ServeCustomer();

        Console.WriteLine("---meetingRoom---");

        MeetingRoom meetingRoom = new MeetingRoom();
        meetingRoom.AddPeopel(humanGenerater.Generate());
        meetingRoom.AddPeopel(humanGenerater.Generate());
        meetingRoom.StartMeeting();
    }
}
class MouthBase
{
    public void eat()
    {
        Console.WriteLine("MouthBase::eat");
    }
}
class MouthHuman : MouthBase
{
    public void speak()
    {
        Console.WriteLine("MouthHuman::speak");
    }
}
class MouthDog : MouthBase
{
    public void bark()
    {
        Console.WriteLine("MouthDog::bark");
    }
}
class AnimalBase
{
    public virtual MouthBase Mouth
    {
        get;
    }
}
class AnimalHuman : AnimalBase
{
    MouthHuman mouthHuman = new MouthHuman();
    public override MouthHuman Mouth
    {
        get { return mouthHuman; }
    }
}
class AnimalDog : AnimalBase
{
    MouthDog mouthDog = new MouthDog();
    public override MouthDog Mouth
    {
        get { return mouthDog; }
    }
}


class Restaurant   //Restaurant可以处理 AnimalBase
{
    List<AnimalBase> customer = new List<AnimalBase>();
    public void AddCustomer(AnimalBase animalBase)
    {
        customer.Add(animalBase);
    }
    public void ServeCustomer()
    {
        foreach (AnimalBase animal in customer)
        {
            animal.Mouth.eat();
        }
    }
}


class MeetingRoom   //MeetingRoom可以处理 AnimalHuman
{
    List<AnimalHuman> peopel = new List<AnimalHuman>();
    public void AddPeopel(AnimalHuman animalHuman)
    {
        peopel.Add(animalHuman);
    }
    public void StartMeeting()
    {
        foreach (AnimalHuman person in peopel)
        {
            person.Mouth.speak();
        }
    }
}




class AnimalGenerater
{
    public virtual AnimalBase Generate()
    {
        return new AnimalBase();
    }
}

class HumanGenerater : AnimalGenerater
{
    public override AnimalHuman Generate()
    {
        return new AnimalHuman();
    }
}

class DogGenerater : AnimalGenerater
{
    public override AnimalDog Generate()
    {
        return new AnimalDog();
    }
}