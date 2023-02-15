// Write a c# program to display the elements of an array
using System;
class ForEachPractice {
  static void Main() {
    Console.WriteLine("ForEach Loop");
    int[] numArray={1,2,3,4,5,6,7,8,9,10};
    foreach (int num in numArray)
    {
        Console.Write("{0}\t",num);
    }
  }
}
