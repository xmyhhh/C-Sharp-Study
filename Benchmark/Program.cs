using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

[MemoryDiagnoser]
public class YieldBenchmarks
{
    [Benchmark]
    public void ProcessPeople()
    {
        var people = GetPeople(1000000);
        foreach (var person in people)
        {
            if (person.Id < 1000)
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
            else
                break;
        }
    }

    IEnumerable<Person> GetPeople(int count)
    {
        List<Person> people = new List<Person>();
        for (int i = 0; i < count; i++)
        {
            people.Add(new Person() { Id = i, Name = $"Name {i}" });
        }
        return people;
    }

    [Benchmark]
    public void ProcessPeopleYield()
    {
        var people = GetPeopleYield(1000000);
        foreach (var person in people)
        {
            if (person.Id < 1000)
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
            else
                break;
        }
    }

    IEnumerable<Person> GetPeopleYield(int count)
    {
        for (int i = 0; i < count; i++)
        {
            yield return new Person() { Id = i, Name = $"Name {i}" };
        }
    }

}



public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
}





class Program
{
    static void Main(string[] args)
    {
        //ProcessPeople();

        var summary = BenchmarkRunner.Run<YieldBenchmarks>();
    }

}