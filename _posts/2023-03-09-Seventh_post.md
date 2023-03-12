---
title: Inheritance, Abstraction and Interfaces
date: 2023-03-10
---

I had fun last week studying the fundamentals of object-oriented programming; now it's time to go further into the concepts. Except for some syntax all the concepts of object oriented programming are very similar to OOP concepts in Java. I have used the programming questions from <a href="https://www.exercisescsharp.com/oop/">exercisecsharp</a> as well as from <a href="https://www.programiz.com/csharp-programming/inheritance">Programiz</a>to test my skills.

<h2>Inheritance</h2>
By allowing new classes to inherit the properties of existing classes, the notion of inheritance enables us to construct new classes from existing ones. The existing class from which new classes are created is known as the ***base class*** or ***parent class*** while the class which inherits the properties of this base class is known as ***child class*** or ***derived class***.
To make a class inherit the properties of another class we use ***colon(':')***  after the child class name followed by the base class name. This style of syntax is a bit different from java where we use ***extends*** keyword to perform inheritance. Below is a basic syntax of inheritance in c#:

```
class BaseClass {  
  // fields and methods
} 
// ChildClass inherits from BaseClass
class ChildClass : BaseClass { 
  // fields and methods of ChildClass 
}
```

There are many different types of inheritance possible in c#. They are:
1. ***Single Inheritance:*** In single inheritance, a single derived class inherits from a single base class.
   ```
   Class A <-- Class B
   ```
2. ***Multilevel Inheritance:*** In multilevel inheritance, a derived class inherits from a base and then the same derived class acts as a base class for another class.
   ```
   Class A <-- Class B <-- Class C
   ```
3. ***Hierarchical Inheritance:*** In hierarchical inheritance, multiple derived classes inherit from a single base class.
   ```
   Class A <-- Class B
   Class A <-- Class C
   ```
4. ***Hybrid Inheritance:*** Hybrid inheritance is a combination of two or more types of inheritance. The combination of multilevel and hierarchical inheritance is an example of Hybrid inheritance.
5. ***Multiple Inheritance:*** In multiple inheritance, a single derived class inherits from multiple base classes. C# doesn't support multiple inheritance. However, we can achieve multiple inheritance through interfaces.

To demonstrate each inheritance type I have written and tested the following programs in c#: <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/OOP/SingleInheritanceEx.cs">SingleInheritanceEx.cs</a>, <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/OOP/MultilevelInheritanceEx.cs">MultilevelInheritanceEx.cs</a>, <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/OOP/HierarchialInheritanceEx.cs">HierarchicalInheritanceEx.cs</a>.

<h2>Abstraction</h2>

<h2>Interfaces</h2>

<h2>Summary</h2>



