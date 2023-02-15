// Write a program in C# Sharp to calculate sum and average of n numbers taken as input from keyboard.
using System;
class W3rLoopsQ4{
  static void Main() {
    Console.Write("Enter n value: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int i = 0;
    Console.WriteLine("Enter {0} numbers: ",n);
    while(i<n)
    {
        sum+=Convert.ToInt32(Console.ReadLine());
        i++;
    }
    Console.WriteLine("\nSum = {0}",sum);
    Console.WriteLine("Average = {0}",((double)sum/n));
  }
}
