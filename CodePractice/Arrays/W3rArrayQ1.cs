// Write a program in C# Sharp to store elements in an array and print it and also print them in reverse order.
using System;
class W3rArrayQ1 {
  static void Main() {
    Console.Write("Enter n value: ");
    int n=Convert.ToInt32(Console.ReadLine());
    int[] numArray= new int[n];
    Console.WriteLine("Enter array values: ");
    for(int i=0;i<n;i++)
    {
        numArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Stored array values: ");
    for(int i=0;i<n;i++)
    {
        Console.Write("{0}\t",numArray[i]);
    }
    Console.WriteLine("\nStored array values in reverse order: ");
    for(int i=n-1;i>=0;i--)
    {
        Console.Write("{0}\t",numArray[i]);
    }
  }
}
