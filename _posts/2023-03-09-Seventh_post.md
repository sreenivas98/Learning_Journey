---
title: Inheritance, polymorphism and method overriding
date: 2023-03-10
---

I had fun last week studying the fundamentals of object-oriented programming; now it's time to go further into the concepts. Except for some syntax all the concepts of object oriented programming are very similar to OOP concepts in Java. I have used the programming questions from <a href="https://www.exercisescsharp.com/oop/">exercisecsharp</a> as well as from <a href="https://www.programiz.com/csharp-programming/inheritance">Programiz</a> to test my skills.

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

<h2>Polymorphism and Method overriding</h2>

The word ***polymorphism*** means taking ***many forms***. This word is used in oop concepts because we can use the same function to perform different actions by overriding the method. For example if we have a base class A with a method func() and a derived class B which inherits A, we can write new implementation for the inherited method func() in class B and use this new functionality anywhere by just creating an object of class B and call the method func() by using the created object. To override a method in a derived class the method should be declared as either virtual or abstract. Below is the syntax for overriding of methods in which we use two crucial keywords ***virtual*** and ***override*** in base class and derived respectively to achieve method overriding:

```
class BaseClass {
  public virtual returnType methodName(){
   // implementation
  }
}
class DerivedClass : BaseClass {
  public override returnType methodName(){
    // new implementation  
  }
}
```

There is a special keyword ***base*** to call the the base class methods from derived class. The basic syntax for doing is given below:

```
base.baseClassParameter 
// this parameter can either be a method or a variable.
```

To demonstrate the concept of method overriding and base keyword I have written <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/OOP/MethodOverridingEx.cs">MethodOverridingEx.cs</a> program.

<h2>Difficulties Faced</h2>
During this week's learning process, I have encountered two challenges. The first involves attempting to call a base class method from a derived class method, and the second involves comprehending the usage of the virtual keyword. I assumed that ***super*** would be the keyword used in c# to call or access base class parameters from derived classes as super was used in java. However, when I tried to use the super keyword in different forms, such as ***super*** and ***super()***, I found that this was not the case. So, I started to look for the exact keyword that could help me achieve this and after a thorough diiging through the internet I found the suitable keyword ***base*** to achieve my goal and succeeded. 

My other challenge was with understanding the usage of ***virtual*** keyword in c# programming language. To understand why this virtual keyword is used in c# i have gone though various websites ignoring microsoft's official website. Every website provided where this keyword was used but not the actual explanation of why. After going through various websites I decided to go through the explanation provided in <a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual">microsoft official website</a> and this one provided a clear explanation of why and where this virtual keyword is used which helped understand everything about this special keyword in c# programming. The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class. For example the below method can be overridden by any class that inherits the below class:
```
class Parallelogram {
  public virtual double Area() {
      return x * y;
  }
}
```
<h2>Next Week Goals</h2>

I have a goal to fully understand all of the ***object-oriented programming*** ideas throughout the course of the upcoming week. In order to grasp object-oriented programming, I still need to understand ***abstraction*** and ***interfaces***. I want to learn about ***files*** and ***exceptions*** in the upcoming week when I've mastered these topics. I want to fully understand every C# idea that will be useful to me in pursuing a career as a.net developer by the conclusion of this semester.


