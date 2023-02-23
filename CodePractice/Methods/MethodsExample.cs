// Write a C# program to include a user defined method with parameters
using System;
class MethodsExample {
  static void Main() {
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();
    printWelcomeMSG(name);
  }	
  
  static void printWelcomeMSG(string name){
      Console.WriteLine("Welcome {0}",name);
  }
}
