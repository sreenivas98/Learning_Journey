---
title: Baby steps in my learning journey
date: 2023-02-08
---

The first step in learning any programming language is to learn the uses of that language. Since I am a software geek like the other programmers, this was my initial move. Learning how to use a programming language inspires and encourages you to gain knowledge of the fundamental to advanced concepts involved in creating programs using that language.

<h2>Applications of C#</h2>
Applications that are both standalone and online may be created using C#. The sole drawback of C# is that it requires the.NET framework in order for applications created with it to function. Microsoft created the programming language C# specifically to build and run programs on the.NET framework.

Although C# is not as well-known as Java, it is regarded as Java's most direct competitor since the two languages have many of the same applications.The creation of video games using the "Unity Game Engine" is the most well-known application of C#.

Microsoft Windows (the operating system), Visual Studio (the code editor), Microsoft Office, AutoCAD, Adobe Photoshop, and Spotify are just a few of the well-known applications that were created utilizing C# and the.NET framework.

<h2>The Basic Syntax - Essential to every programming language</h2>
My next step after learning about applications C#, was to understand the language's fundamental syntax. To do this, the sample program below was quite helpful.

```
using System;
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
}
```
Line1: Using System means that we can use classes from the System namespace.

Line2: White space is ignored in C#. The code is better understandable when there are more lines, though. 

Line3: A namespace serves as a container for classes and other namespaces and is used to structure your code. 

Line4: A block of code has a beginning and an end indicated by curly brackets ('{}'). 

Line5: A class is a container for data and operations that gives your application functionality. Every line of C# code that executes must be contained within a class. We gave the class in our example the name Program.

<br>
I've downloaded and installed the most recent version of the <a href="https://dotnet.microsoft.com/en-us/download">.NET framework (V7.0)</a> from the official Microsoft website, along with <a href="https://code.visualstudio.com/Download">Visual Studio Code</a>, which allows me to edit C# program files.
<br>
<br>
There are a few steps involved in setting up the whole environment to create,edit and run c# programs:
<br>


<h2>Writing the First Program</h2>

I created the standard program that every programmer learns to create, the Hello World Program but I made a tiny modification based on the programming question offered by w3Resources. I created two print statements, one to print hello and the other to print my name. C# and C++ have nearly identical syntax. 

To show that we are using the classes from the System package, we put ```using System``` on the first line, followed by ```namespace NameSpaceName``` to organize our code. Each block of code is enclosed within flower braces "{}". As C# is a programming language that adheres to the Object Oriented Programming methodology, we build a class that contains the main method and write the main method as a member function of that class, similarly to Java.

To refer my first C#program code click <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/W3rBasic/W3rBasicQ1">W3Resorurce_Basic_Q1.cs</a>
