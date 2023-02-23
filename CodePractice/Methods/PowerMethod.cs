// Write a C# method which calculates the value of an integer raised to the power of another integer
using System;
class PowerMethod {
  static void Main() {
    Console.Write("Enter the base: ");
    int baseNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the exponent: ");
    int expNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("{0}^{1} = {2}",baseNum,expNum,calculatePower(baseNum,expNum));
  }	
  
  static int calculatePower(int baseNum,int expNum){
      int result=1;
      for(int i=1;i<=expNum;i++)
      {
          result*=baseNum;
      }
      return result;
  }
}
