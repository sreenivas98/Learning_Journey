//Write a C# Sharp program to find whether a given year is a leap year or not.
using System;
class W3rConditionalQ4{
  static void Main() {
    int chk_year= Convert.ToInt32(Console.ReadLine());
    if ((chk_year % 400) == 0)
        Console.WriteLine("Leap year");
    else if ((chk_year % 100) == 0)
        Console.WriteLine("Not a leap year");
    else if ((chk_year % 4) == 0)
        Console.WriteLine("Leap year");
    else 
        Console.WriteLine("Not a leap year");
  }
}
