---
title: Object Oriented Programming Concepts
date: 2023-03-01
---

I eventually moved ahead to understand the principles of object-oriented programming in C# after a six-week trip that started with learning basic syntax and ended with learning methods and method overloading. I learned about the fundamentals of Object-Oriented Programming throughout my college studies when studying Java, therefore I am extremely familiar with them. Apart from the syntax of specific concepts like inheritance, all of the ideas of object-oriented programming are the same in both Java and C#. The principles weren't too tough for me to understand, but I had to go around a lot in search of exercises that used OOP concepts. I eventually hit the jackpot when I discovered the 93dcw website, which has a few questions about Object Oriented programming ideas.

<h2>Basics of OOP - Classes and Objects</h2>
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
 


<h2>Methods and Method Overloading</h2>



<h2>Difficulties Faced and Solutions Derived</h2>



