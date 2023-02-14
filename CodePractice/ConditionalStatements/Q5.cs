//Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
using System;
class W3rConditionalQ5{
  static void Main() {
    int chk_age= Convert.ToInt32(Console.ReadLine());
    if (chk_age >= 18)
        Console.WriteLine("Eligible to vote");
    else 
        Console.WriteLine("Not eligible to vote");
  }
}
