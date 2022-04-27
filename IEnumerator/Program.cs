


using System.Collections;

class Program
{



    static void Main()
    {

        //DogShelter dogShelter = new DogShelter();

        //foreach (var item in dogShelter)
        //{
        //    if (!item.IsNaughtyDog)
        //    {
        //        item.GiveTreat(1);
        //    }
        //    else
        //    {
        //        item.GiveTreat(2);
        //    }
        //}

        IEnumerable<int> unknownCollection;
        unknownCollection = GetCollection(3);

        foreach (var item in unknownCollection)
        {
            Console.WriteLine(item.ToString());
        }
    }


    static IEnumerable<int> GetCollection(int opt)
    {
        //list queue array
        List<int> numberList = new List<int>()
        {
            1,2,3,4,5
        };

        Queue<int> numberQueue = new Queue<int>();
        numberQueue.Enqueue(6);
        numberQueue.Enqueue(7);
        numberQueue.Enqueue(8);
        numberQueue.Enqueue(9);
        numberQueue.Enqueue(10);


        switch (opt)
        {
            case 0:
                return numberList;


            case 1:
                return numberQueue;


            default:
                return new int[] { 11, 12, 13, 14, 15 };
        }
    }
}


class DogShelter : IEnumerable<Dog>
{
    //list of type List&lt;Dog&gt;
    public List<Dog> dogs;

    public DogShelter()
    {
        //initialize the dogs list using the collection-initializer
        dogs = new List<Dog>() {
            new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false),
            };
    }

    public IEnumerator<Dog> GetEnumerator()   //Generic 
    {
        return dogs.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()   //non-Generic   DogShelter实现的是IEnumerable<T>,因此foreach只调用IEnumerator<Dog> GetEnumerator()，不用实现这个方法
    {
        throw new NotImplementedException();
    }
}
//a class named Dog which we will use in another class called DogShelter which will contain a collection of this class
class Dog
{
    //the name of the dog
    public string Name { get; set; }
    //is this a naughty dog
    public bool IsNaughtyDog { get; set; }
    //simple constructor 
    public Dog(string name, bool isNaughtyDog)
    {
        this.Name = name;
        this.IsNaughtyDog = isNaughtyDog;

    }
    //this method will print how many treats the dog received 
    public void GiveTreat(int numberofTreats)
    {
        //print a message containing the number of treats and the name of the dog
        Console.WriteLine("Dog: {0} said wuoff {1} times!.", Name, numberofTreats);

    }
}