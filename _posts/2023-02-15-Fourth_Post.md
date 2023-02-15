---
title: Conditional Statements and Looping
date: 2023-02-15
---

The fundamentals of C#, including the syntax, data types, and type casting, are now under my belt. It's time to advance and study operators, conditional and looping expressions. 

<h2>Playing with Conditional Statements</h2>
I've advanced to understanding conditional statements and expressions after learning the different C# operators. The "if," "if else," and "else if" conditional statements are included in C#, along with one extra conditional statement known as the ternary operator or the shorthand if...else. The following are some examples which helped me understand these conditional statements:

1. ***if***
```
if (20 > 18) 
{
  Console.WriteLine("20 is greater than 18");
}
```
2. ***if else***
```
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
```
3. ***else if***
```
int time = 22;
if (time < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
```
4. ***Ternary operator***
```
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
```
<h2></h2>


