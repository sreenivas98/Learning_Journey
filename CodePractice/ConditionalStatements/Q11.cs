// Write a C# Sharp program to calculate root of Quadratic Equation.
using System;
class W3rConditionalQ11 {
  static void Main() {
    Console.WriteLine("Enter 'a' value: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter 'b' value: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter 'c' value: ");
    int c = Convert.ToInt32(Console.ReadLine());
    double d,x1,x2;
    d=b*b-4*a*c;
    if(d==0)
    {
        Console.WriteLine("Both roots are equal.");
        x1=-b/(2.0*a);
        x2=x1;
        Console.WriteLine("First  Root Root1= {0}",x1);
        Console.WriteLine("Second Root Root2= {0}",x2);
    }
    else if(d>0)
    {
	Console.WriteLine("Both roots are real and diff-2");
        x1=(-b+Math.Sqrt(d))/(2*a);
        x2=(-b-Math.Sqrt(d))/(2*a);
        Console.WriteLine("First  Root Root1= {0}",x1);
        Console.WriteLine("Second Root root2= {0}",x2);
    }
    else
        Console.WriteLine("Roots are imaginary");
  }
}
