// Write a program in C# Sharp to display the first 10 natural numbers.
using System;
class W3rLoopsQ1{
  static void Main() {
    Console.WriteLine("For Loop");
    int i;
    for(i=1;i<=10;i++)
    {
        Console.Write("{0}\t",i);
    }
    Console.WriteLine("\nWhile Loop");
    i=1;
    while(i<=10)
    {
        Console.Write("{0}\t",i);
        i++;
    }
    Console.WriteLine("\nDo-While Loop");
    i=1;
    do
    {
        Console.Write("{0}\t",i);
        i++;
    }while(i<=10);
  }
}
