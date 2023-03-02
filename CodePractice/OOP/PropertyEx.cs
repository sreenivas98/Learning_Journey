using System;
class PropertyEx
{
    static void Main(string[] args)
    {
        Car myCar = new Car(){model = Console.ReadLine()};
        Console.WriteLine(myCar.ToString());
    }
}
class Car
{
    public string model {get; set; }
    public override string ToString()
    {
        return "Hello! The car model is " + model;
    }
}
