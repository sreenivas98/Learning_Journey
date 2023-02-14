using System;
class W3rConditionalQ2{
  static void Main() {
    int myNum= Convert.ToInt32(Console.ReadLine());
    if(myNum%2==0)
        Console.WriteLine("Even");
    else
        Console.WriteLine("Odd");
  }
}
