---
title: Baby steps in my learning journey
date: 2023-02-08
---

While browsing the internet, I discovered <a href="https://www.w3schools.com/cs/index.php">w3schools</a> and <a href="https://www.tutorialspoint.com/csharp/index.htm">tutorialspoint</a>, which are extremely useful for learning C# programming language, as well as <a href="https://www.w3resource.com/csharp-exercises/">w3resources</a>, which I can use to test my understanding of C#. On the W3Resources website, there are hundreds of programming problems arranged according to various topics, ranging from simple to complex, such as operators, datatypes, conditional statements, etc., to which you may add code to hone your C# programming abilities.

<h2>Basic Environment Setup</h2>
The first and most important step in any programming language is to build up the appropriate infrastructure for producing and using program files. We must install the.NET framework on our system in order to use the C# programming language, which is required to compile and run C# programs. Microsoft created the.NET framework to let developers build a variety of apps, from straightforward web applications to sophisticated video games.
<br>
<br>
I've downloaded and installed the most recent version of the <a href="https://dotnet.microsoft.com/en-us/download">.NET framework (V7.0)</a> from the official Microsoft website, along with <a href="https://code.visualstudio.com/Download">Visual Studio Code</a>, which allows me to edit C# program files.
<br>
<br>
There are a few steps involved in setting up the whole environment to create,edit and run c# programs:
<br>

1. Download and install .NET framework (v7.0) from official microsoft site. To check if .NET is installed on our system, run the below code in windows powershell.
```
dotnet --version
```
2. Download and install Visual Studio Code from official site.
3. Add C# extension to Visual Studio Code.
4. Add Code Runner extension to Visual Studio Code.
5. Create a basic console app for use in VS code by navigating to the desired folder in command prompt and running the below code in command prompt.
```
dotnet new console
```
6. Open the project in VS code and write the C# code in program.cs file created by running the above code and save the file.
7. There are two ways to run the C# program in VS Code:


   a. Using terminal code: open a new terminal and run the below code to get the output.
   ```
   dotnet run
   ```
   b. Using Code Runner extension: <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/codeRunnerSettings">Go To Settings document</a>

<h2>Writing the First Program</h2>

I created the standard program that every programmer learns to create, the Hello World Program but I made a tiny modification based on the programming question offered by w3Resources. I created two print statements, one to print hello and the other to print my name. C# and C++ have nearly identical syntax. 

To show that we are using the classes from the System package, we put ```using System``` on the first line, followed by ```namespace NameSpaceName``` to organize our code. Each block of code is enclosed within flower braces "{}". As C# is a programming language that adheres to the Object Oriented Programming methodology, we build a class that contains the main method and write the main method as a member function of that class, similarly to Java.

To refer my first C#program code click <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/W3rBasic/W3rBasicQ1">W3Resorurce_Basic_Q1.cs</a>
