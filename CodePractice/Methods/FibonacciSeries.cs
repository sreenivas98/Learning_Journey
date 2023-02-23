// Write a program in C# Sharp to create a function to display the n number Fibonacci sequence
using System;
class FibonacciSeries{
  static void Main(){
    Console.Write("Enter N value: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Fibonacci Sequence of {0} numbers is: {1}",n,string.Join(" ",getFebonacciSequence(n)));
  }	
  
  static int[] getFebonacciSequence(int n){
      int[] f = new int[n];
      f[0]=0;
      f[1]=1;
      for(int i=2;i<n;i++)
      {
          f[i]=f[i-1]+f[i-2];
      }
      return f;
  }
}
