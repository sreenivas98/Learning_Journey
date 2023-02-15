// Write a program in C# Sharp to accept a grade and display the equivalent description:
using System;
class W3rConditionalQ19
   {
       static void Main()
    {
    string notes;
    char grd;
    Console.Write("Input the grade :");
    grd = Convert.ToChar(Console.ReadLine().ToUpper());

    switch(grd)
    {
    case 'E':
        notes= " Excellent";
        break;
    case 'V':
       notes= " Very Good";
        break;
    case 'G':
        notes= " Good ";
        break;
    case 'A':
        notes= " Average";
        break;
    case 'F':
        notes= " Fails";
        break;
    default :
        notes= "Invalid Grade Found.";
        break;
    }
    Console.WriteLine("Student grade description: {0}",notes);
} 
}
