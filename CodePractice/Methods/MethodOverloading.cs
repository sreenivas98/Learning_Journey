// Method overloading of sum() method
using System;
class MethodOverloading{
  static void Main() {
    int i1=5;
    int i2=10;
    float f1=5.5F;
    float f2=10.3F;
    string s1="Hello";
    string s2="World";
    Console.WriteLine("Integer sum = {0}",sum(i1,i2));
    Console.WriteLine("Floating point numbers sum = {0}",sum(f1,f2));
    Console.WriteLine("String concatenation with space in between = {0}",sum(s1,s2));
  }
  static int sum(int x,int y){
      return x+y;
  }
  static string sum(string x, string y){
      return x+" "+y;
  }
  static float sum(float x,float y){
      return x+y;
  }
}
