using System;
class Car
{
    string Model;
    public Car(string Model)
    {
        this.Model = Model;
    }
    public void getModel()
    {
        Console.WriteLine(Model);
    }
}

class ConstructorEx
{
    static void Main(string[] args)
    {
        Car myCar = new Car("BMW");
        myCar.getModel();
    }
}
