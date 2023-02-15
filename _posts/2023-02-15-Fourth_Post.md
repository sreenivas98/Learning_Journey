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

We also have a switch statement that, in addition to these conditional statements, chooses the code block based on the value we pass to the switch case. I've used the example below as a guide so I can comprehend it easily.
```
int day = 4;
switch (day) 
{
  case 6:
    Console.WriteLine("Today is Saturday.");
    break;
  case 7:
    Console.WriteLine("Today is Sunday.");
    break;
  default:
    Console.WriteLine("Looking forward to the Weekend.");
    break;
}
```
In the code above, the switch statement's default block is executed since the number 4 is absent in all situations.
At the conclusion of my study of conditional statements, I used the knowledge I had gained to answer programming problems highlighted by W3Resources on the internet. I have written various programs using conditional statements such as <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/ConditionalStatements/Q1.cs">'Checking whether two numbers are equal'</a>, <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/ConditionalStatements/Q11.cs">'Calculating quadratic equation roots'</a> and so on.To view all my practice problems on conditional statements, visit <a href="https://github.com/sreenivas98/Learning_Journey/tree/main/CodePractice/ConditionalStatements">Conditional Statements Practice</a>.

<h2>Handling Loops like a pro.</h2>

I am already familiar with all of the loops accessible in c# because the concepts and implementations of several loops in c# and java programming languages are the same, covering "for", "while", and "do while" loops. Despite my familiarity with the notion, I began creating programs in C# that implemented the concept of loops to sharpen my abilities and test my understanding of this particular subject. To do this, I reviewed many programming questions on loops from <a href="https://www.w3resource.com/csharp-exercises/for-loop/index.php">W3Resources</a> on the internet.
The following is the basic syntax of various loops:
1. ***for***
```
for (intialization; condition; increment) 
{
  // code block to be executed
}
```
2. ***while***
```
while (condition) 
{
  // code block to be executed
}
```
3. ***do while***
```
do
{
  //  code block to be executed
} while (condition);
```

Along with all of these loops, I've discovered a new looping concept: the foreach loop in C#. The foreach loop is mostly used to scan through arrays in order to print out the contents or execute other actions on the array elements. The syntax for a ***foreach*** loop is as follows:
```
foreach (type variableName in arrayName) 
{
  // code block to be executed
}
```
To practice building programs using foreach loops, I needed to master array declaration and initialization in c#. Fortunately, arrays in c# were extremely similar to arrays in java programming language, and I already knew java. I was able to develop programs that used foreach and, thankfully, brush up on my array abilities in the process. To test foreach loop in c#, I have written a <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/w3schools_practice/ForEachPractice.cs">program to print all the elements of an array</a>.

I was able to put my understanding of looping statements to the test by creating programs that use for, while, and do while loops. To illustrate all three loops, I wrote a <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Loops/Q1.cs">program to display the first ten natural numbers</a>, and to practice the while loop, I wrote a <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Loops/Q3.cs">program to display n natural numbers, their total, and average</a>.
