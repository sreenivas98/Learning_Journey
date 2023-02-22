// Write a program in C# Sharp to store elements in an array and sort them in ascending order.
using System;
class ArraySort {
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
    for(int i=0;i<n;i++)
    {
        for(int j=0;j<n-1;j++)
        {
            if(numArray[i]>numArray[j])
            {
                numArray[i]=numArray[i]+numArray[j];
                numArray[j]=numArray[i]-numArray[j];
                numArray[i]=numArray[i]-numArray[j];
            }
        }
    }
    Console.WriteLine("\nStored array values in ascending order: ");
    for(int i=n-1;i>=0;i--)
    {
        Console.Write("{0}\t",numArray[i]);
    }
  }
}
