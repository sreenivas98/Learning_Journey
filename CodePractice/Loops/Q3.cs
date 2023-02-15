// Write a program in C# Sharp to display n terms of natural number, their sum and their average.
using System;
class W3rLoopsQ3{
  static void Main() {
    Console.Write("Enter n value: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int i = 1;
    while(i<=n)
    {
        sum+=i;
        Console.Write("{0}\t",i);
        i++;
    }
    Console.WriteLine("\nSum = {0}",sum);
    Console.WriteLine("Average = {0}",((double)sum/n));
  }
}
