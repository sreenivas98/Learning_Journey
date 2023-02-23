---
title: Arrays, Methods and Method overloading
date: 2023-02-22
---

Now that I've finished learning about C#'s conditional statements and loops, it's time to move on to the next stage of my learning process: which is learning about arrays and methods. I need to address the significant challenge I ran into last week before moving on to the upcoming topics. I searched a number of places for a precise answer to my issue, but was unable to, so I was forced to keep using the <a href="https://www.onlinegdb.com">Online GDB compiler</a> to test the programs I had created.

<h2>Arrays - The Head of Data Structures</h2>
I didn't mean to imply that arrays are the most potent data structures available when I referred to them as the head of the data structures, but rather that they are the form of data structure that many programming languages now in use utilize the most commonly. An array is a type of data structure that can hold multiple values of the same data type. The basic syntax of declaring an array is:

``` dataType[] variableName = new dataType[size];```

An array's size is set at the time of declaration and cannot be altered while a program is running. Each and every element in an array can be accessed by their index value which starts from ***0*** till ***Size-1***. The syntax for accessing an element in array is: 

``` ArrayName[index value] ```

The elements of an array should always be enclosed in between ***flower braces ("{","}")*** seperated by a ***comma (",")***. 

I ran through the following program to better grasp the idea of arrays. It builds an array of vehicle model names and outputs the first entry of the array.

```
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
```

I wrote a few programs that employ arrays to carry out various operations to put my newly learned understanding of the concept of arrays to the test.

1. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Arrays/W3rArrayQ1.cs">Program to store and print elements of an array from both ways</a>
2. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Arrays/MaxMinArray.cs">Program to find max and min element in an array</a>
3. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Arrays/ArraySort.cs">Program to sort the elements of an array in ascending order</a>


<h2>Methods and Method Overloading</h2>

As I am familiar with C++ programming, I found the learning of methods simple and easy. Methods are basically blocks of code that only get executed when they are called. A method is defined with the name of the method, followed by parentheses () and the code to be executed is enclosed within flower brackets {}. Methods should always be written inside a class in a program. Below is the basic syntax of writing methods in C#: 

```
class ClassName
{
  static DataType MethodName(parameter list along with their data types) 
  {
    // code to be executed
  }
}
```

In the above syntax the ***DataType*** defines the returning value type which will be returned to the caller. The keyword ***static*** states that method belongs to the specific class and not on an object of the class. I studied the following program from the W3Schools tutorial to the best of my ability in order to comprehend the concept of methods.

```
using System;
namespace MyApplication
{
  class Program
  {
    static void MyMethod()
    {
      Console.WriteLine("I just got executed!");
    }

    static void Main(string[] args)
    {
      MyMethod();
    }
  }
}
```

I've created and tested the following C# programs to demonstrate my understanding of the concept of methods.

1. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Methods/MethodsExample.cs">User defined method with parameters.</a>
2. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Methods/PowerMethod.cs">Method to calculate the result of an integer raised to power of another integer</a>
3. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Methods/FibonacciSeries.cs">Method to return a fibonacci series upto n numbers</a>

We can solve many problems by dividing the whole problem into sub problems, and writing recursive functions is the best thing to do so. Recursive methods are functions that call themselves within their own definition. Recursive methods have a base case and a recursive case. The base case is the stopping condition that prevents the function from calling itself indefinitely. The recursive case is the part of the function that calls itself with a smaller or simpler input, eventually leading to the base case. To test my understanding of recursive methods I have written a <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Methods/RecursiveFactorial.cs">recursive method to calculate the factorial of a given number</a>.

C# being an object oriented programming language possess the ability of method overloading. The idea of method overloading states that a class may include numerous methods with the same name. Each method in method overloading has a distinct signature based on the quantity, type, and order of its parameters. Based on the inputs supplied to a method when it is called, the compiler chooses which method to run. One of the overloaded methods is run if the parameters match the method's signature. If not, the compiler will continue to search for overloaded methods until it finds one that matches the signature or an error is raised. The <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Methods/MethodOverloading.cs">MethodOverloading.cs</a> example clearly explains the concept of method overloading where various methods having the same name are written with different return types as well as different types of parameters.

<h2>Difficulties Faced and Solutions Derived</h2>
I haven't had many difficulties learning this week. The only issue I've encountered was while attempting to use ***Console.WriteLine()*** to display an array's elements. I explored several different approaches to address this problem before discovering a predefined function from the string class called "Join()," which can be used to combine the elements of an array into a single string value that is separated by a given seperator. For example, we can use
***string.Join(",",array)*** to combine the array elements into a single string value seperated by commas. The below code explains the Join operator clearly.

```
int[] arr = {1,2,3,4,5}
Console.Write("Array Elements: {0}",string.Join(",",arr));
/* output
Array Elements: 1,2,3,4,5*/
```
