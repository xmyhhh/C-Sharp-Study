class Program
{
    static void Main()
    {
        ProceessPeople_yield_Enumerator();
    }
    public static void ProceessPeople_yield_Enumerator()   //不借助foreeach，自己使用迭代器的写法
    {
        var people_Enumerator = GetPeople_yield(10000).GetEnumerator();

        while (people_Enumerator.MoveNext())
        {
            var person = people_Enumerator.Current;
            Console.WriteLine(person.ID.ToString());
            if (person.ID > 100)
            {
                break;
            }

        }
    }
    public static void ProceessPeople_yield()
    {
        var people = GetPeople_yield(10000);

        foreach (var person in people)
        {
            Console.WriteLine(person.ID.ToString());
            if (person.ID > 100)
            {
                break;
            }

        }
    }
    public static void ProceessPeople()
    {
        var people = GetPeople(10000);

        foreach (var person in people)
        {
            Console.WriteLine(person.ID.ToString());
            if (person.ID > 100)
            {
                break;
            }

        }
    }

    public static IEnumerable<Person> GetPeople(int count)   //以List的形式存储所有person，然后返回整个List
    {


        List<Person> people = new List<Person>();
        for (int i = 0; i < count; i++)
        {
            people.Add(new Person(i));
        }

        return people;
    }
    public static IEnumerable<Person> GetPeople_yield(int count)  //以yield的形式返回一个可迭代对象，类型为System.Collections.Generic.Ienumerable<Person>
    {

        for (int i = 0; i < count; i++)
        {
            yield return new Person(i);
        }

    }
}

public class Person
{
    int id;
    public Person(int m_ID)
    {
        ID = m_ID;
    }
    public int ID
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }
}