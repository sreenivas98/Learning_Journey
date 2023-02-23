// Write a program in C# Sharp to create a recursive function to calculate the factorial of given number
using System;
class RecursiveFactorial{
  static void Main(){
    Console.Write("Enter N value: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Factorial of {0} is: {1}",n,calculateFactorial(n));
  }	
  
  static int calculateFactorial(int n){
    if(n==1)
    {
        return 1;
    }
    return n*calculateFactorial(n-1);
  }
}
