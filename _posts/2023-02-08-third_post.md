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

<h2>Learning Datatypes and TypeCasting</h2>
Now that I am familiar with C# fundamental  grammar, I must continue on my trip. The next step is to become familiar with the many datatypes that are offered by this language. There are seven basic datatypes offered by C#, including int(size:4bytes) and long(size:8bytes) for integer numbers, float(size:4bytes) and double(size:8bytes) for decimal numbers, char(size:2bytes) for a single character (either alphabetic or special), bool for a boolean datatype with a value of 0 or 1, and string for holding a collection of characters.

Below are a few programs of c# that I have written for demonstrating the different datatypes present in c# by creating a variable with the mentioned datatype and printing them out onto the terminal screen:

1. int: size - 4 bytes;  range - (-2,147,483,648 to 2,147,483,647)
```
int x=10000;
Console.WriteLine(x);
```

2. long: size - 8 bytes;  range - (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
```
long x=1000000000000L;
Console.WriteLine(x);
```

3. float: size - 4 bytes;  range - stores 6 to 7 decimal digits
```
float x=15.09F;
Console.WriteLine(x);
```

4. double: size - 8 bytes;  range - stores up to 15 decimal digits
```
double x=15.9865444D;
Console.WriteLine(x);
```

5. bool: size - 1 bit; value - either 0(false) or 1(true)
```
bool valueT=true;
bool valueF=false;
Console.WriteLine(valueT);
Console.WriteLine(valueF);
```

6. char: size - 2 bytes; values - alphabets or special characters
```
char alphabet='S';
Console.WriteLine(alphabet);
```

7. string: size - 2bytes for each character included; values - collection of characters
```
string greeter="Hello World!";
Console.WriteLine(greeter);
```

Given that type casting exists in every language When I started looking for the types or concepts of type casting in C#, I discovered several websites that provided explanations. Type casting basically entails changing a variable from one data type to another. This process appears straightforward, but there is a catch. For instance, you cannot type cast a long variable into an integer since long has a far higher range than int, and you also cannot type convert a double variable into a float automatically. Although you can perform manual typecasting also known as Explicit type casting for converting long to int and double to float.

There are two types of type casting:
1. Implicit casting: converting of smaller type to larger type automatically.
```
char -> int -> long -> float -> double
```

2. Explicit casting: converting a larger type to smaller type manually.
```
double -> float -> long -> int ->char
```

Explicit type casting can be done by two ways:
1. By place the type in parantheses in front of the value.
2. By using built-in methods like ```Convert.ToBoolean```, ```Convert.ToDouble```, ```Convert.ToString```, ```Convert.ToInt32(int)```, etc.

