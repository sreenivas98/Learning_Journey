// Write a C# program to find maximum and minimum elements in an array
using System;
class MaxMinArray {
  static void Main() {
    Console.Write("Enter N value: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr1 = new int[n];
    Console.Write("Enter array values: ");
    for(int i=0;i<n;i++)
    {
        arr1[i]=Convert.ToInt32(Console.ReadLine());
    }
    int mx = arr1[0];
    int mn = arr1[0];
    for(int i=1; i<n; i++)
    {
        if(arr1[i]>mx)
        {
            mx = arr1[i];
        }


        if(arr1[i]<mn)
        {
            mn = arr1[i];
        }
    }
    Console.WriteLine("Maximum element is : {0}", mx);
    Console.WriteLine("Minimum element is : {0}", mn);
  }	
}
