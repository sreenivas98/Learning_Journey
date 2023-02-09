using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      double myDouble = 9.78;
      int myInt = (int) myDouble;  // Manual casting: double to int
      double myDouble2 = 10.89;
      int myInt2 = Convert.ToInt32(myDouble2); // Manual Casting using built-in method: double to int
      Console.WriteLine(myDouble);
      Console.WriteLine(myInt);
      Console.WriteLine(myDouble2);
      Console.WriteLine(myInt2);
    }
  }
}
