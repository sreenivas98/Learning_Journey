using System;
public class ConstructorEx
{
    public static void Main(string[] args)
    {
        int total = 3;
        Person[] persons = new Person[total];
        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person(Console.ReadLine());
        }
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
        Person Defaulter = new Person();
        Console.WriteLine(Defaulter.ToString());
    }
}
 
public class Person
{
    string Name;
    public Person()
    {
        Name="Default";
    }
    public Person(string Name)
    {
        this.Name=Name;
    }
    public override string ToString()
    {
        return "Hello! My name is " + Name;
    }
}
