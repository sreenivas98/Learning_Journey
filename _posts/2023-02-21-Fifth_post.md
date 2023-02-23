---
title: Arrays, Methods and Method overloading
date: 2023-02-22
---

Now that I've finished learning about C#'s conditional statements and loops, it's time to move on to the next stage of my learning process: which is learning about arrays and methods. I need to address the significant challenge I ran into last week before moving on to the upcoming topics. I searched a number of places for a precise answer to my issue, but was unable to, so I was forced to keep using the <a href="https://www.onlinegdb.com">Online GDB compiler</a> to test the programs I had created.

<h2>Arrays - The Head of Data Structures</h2>
I didn't mean to imply that arrays are the most potent data structures available when I referred to them as the head of the data structures, but rather that they are the form of data structure that many programming languages now in use utilize the most commonly. An array is a type of data structure that can hold multiple values of the same data type. The basic syntax of declaring an array is: ``` dataType[] variableName = new dataType[size];```. An array's size is set at the time of declaration and cannot be altered while a program is running. Each and every element in an array can be accessed by their index value which starts from "0" till "Size-1". The syntax for accessing an element in array is: ``` ArrayName[index value] ```. The elements of an array should always be enclosed in between flower braces ("{","}") seperated by a comma (","). I ran through the following program to better grasp the idea of arrays. It builds an array of vehicle model names and outputs the first entry of the array.
```
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
```
I wrote a few programs that employ arrays to carry out various operations to put my newly learned understanding of the concept of arrays to the test.
1. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Arrays/W3rArrayQ1.cs">Program to store and print elements of an array from both ways</a>
2. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Arrays/MaxMinArray.cs">Program to find max and min element in an array</a>
3. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/Arrays/ArraySort.cs">Program to sort the elements of an array in ascending order</a>


<h2>Handling Loops like a pro.</h2>



<h2>Difficulties Faced and Solutions Derived</h2>
