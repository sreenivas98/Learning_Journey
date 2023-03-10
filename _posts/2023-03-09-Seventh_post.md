---
title: Inheritance, Abstaction and Interfaces
date: 2023-03-01
---

I had fun last week studying the fundamentals of object-oriented programming; now it's time to go further into the concepts. Except for some syntax all the concepts of object oriented programming are very similar to OOP concepts in Java. I have used the programming questions from <a href="https://www.exercisescsharp.com/oop/">exercisecsharp</a> to test my skills.

<h2>Inheritance</h2>
OOP concept is basically about putting all the common members (Variables, methods) under one template which is referred to as a class, and creating instances of this class whenever and wherever required which are referred to as the objects of a class. Classes can be considered as templates while objects can be considered as instances created using the templates/Classes. The whole concept of classes can be referred to as ***Encapsulation***, which means binding together various components into one single capsule.

A class can be created by using the keyword ***class*** followed by class name, and enclosing all the members which can be either variables of different primary data of class in between ***flower braces ("{","}")***. While it is not necessary, it is a good practice to begin class names with an uppercase letter. Also, it is typical for the class name and the C# file name to coincide because this helps to organize our code. But it's not necessary (like in Java). Below is the basic syntax for creating a class:

```
class ClassName
{
  variables of class;
  methods of class;
}
```

When creating an object, the class name is used as the data type, followed by the object's name, the fundamental assignment operator ("="), ***new*** keyword, and finally the constructor. Below is the basic syntax for creating an object of a class:

```
ClassName objName = new ClassName();
```

We use the dot syntax (.) to access variables/methods inside a class (objName.member).To clearly understand this concept of encapsulation I have written the following program and parsed through it.

```
using System;
class Car
{
public string color = "red";
}
class MainClass
{
static void Main(string[] args)
{
Car myCar = new Car();
Console.WriteLine(myCar.color);
}
}
```

To brush up my skills on this concept I have written a program to <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/OOP/ClassExample.cs">create a class person with a toString() method and create objects for this class and call this method using the objects created</a>.
 
After I am done learning the basic concepts of classes and objects, I moved on to learn about the constructors of a class. A constructor is a special method that is used to initialize objects. The advantage of a constructor is that it is the first method to be called when an object of a class is created. It can be used to set initial values for fields/variables. Below example demonstrates a constructor of class named Car:

```
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
```

To better demonstrate constructor concept I have written the above <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/OOP/ConstructorEx.cs">Person class program using a constructor</a>. I have written two constructors one with parameters and one without parameters (also known as default constructor).

<h2>Access modifiers and Properties</h2>
The visibility and access level of classes, fields, methods, and properties are controlled by the use of access modifiers, which are keywords like public, private, protected, and internal. Use of ***public*** keyword before a class, method, field, and property states that the code is accessible for all classes, use of ***private*** keyword states that the code is only accessible within the same class, use of ***protected*** keyword states that the code is accessible within the same class, or in a class that is inherited from that class, and use of ***internal*** keyword states that the code is only accessible within its own assembly, but not from another assembly.

A property is like a combination of a variable and a method, and it has two methods: a get and a set method. Private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties. The below examples clearly provides a walkthrough through the concept of properties in c#:

```
class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
```

To better comprehend the concept of properties I have written a <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/OOP/PropertyEx.cs">program with Car class using the concept of properties in c#</a>.

<h2>Difficulties Faced</h2>
I'm still having trouble with visual studio code, like I did last week. I still totally relied on the OnlineGDB compiler this week to test my programs. Understanding the idea of properties and the various C# implementations of them was another challenge I encountered this week. I spent additional time just on this idea before I was finally able to comprehend properties in C# with clarity.

<h2>Summary</h2>
OOP concept can be very helpful for writing programs that are prone to violating the Don't Repeat Yourself (DRY) principle. As you are just creating objects in required places instead of defining each and every field and method of a class you are able to make the progrm follow DRY principle.



