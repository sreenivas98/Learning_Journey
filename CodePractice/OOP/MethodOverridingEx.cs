using System;
// base class
class Animal { 
    public virtual void eat() {

      Console.WriteLine("I eat food");
    }
} 
  
// derived class of Animal 
class Dog : Animal {

    // overriding method from Animal
    public override void eat() {
        base.eat();
      Console.WriteLine("I eat Dog food");
    }     
}
class MethodOverridingEX {

    static void Main(string[] args) {
      // object of derived class
      Dog labrador = new Dog();

      // accesses overridden method
      labrador.eat();
    }
}
