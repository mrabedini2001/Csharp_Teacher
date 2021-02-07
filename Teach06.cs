//  C# Type Casting
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int myInt = 9;
      double myDouble = myInt;  // Automatic casting: int to double
      Console.WriteLine(myInt);
      Console.WriteLine(myDouble);

      
      double myDouble = 9.78;
      int myInt = (int) myDouble;    // Manual casting: double to int
      Console.WriteLine(myDouble);   // Outputs 9.78
      Console.WriteLine(myInt);      // Outputs 9


      int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;
        Console.WriteLine(Convert.ToString(myInt));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
    }
  }
}