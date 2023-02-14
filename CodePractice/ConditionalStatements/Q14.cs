// Write a C# Sharp program to calculate root of Quadratic Equation.
using System;
class W3rConditionalQ14 {
  static void Main() {
    Console.Write("Enter side 1 length: ");
    int s1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter side 2 length: ");
    int s2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter side s3 length: ");
    int s3 = Convert.ToInt32(Console.ReadLine());
    if(s1==s2 && s1==s3)
        Console.WriteLine("Equilateral Triangle");
    else if(s1==s2 || s2==s3 || s3==s1)
	    Console.WriteLine("Isosceles triangle");
    else
        Console.WriteLine("Scalene triangle");
  }
}
