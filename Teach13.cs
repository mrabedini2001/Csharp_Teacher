//  switch in c#
/*
switch(expression) 
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default:
    // code block
    break;
}
*/
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int day = 4;
      switch (day) 
      {
        case 6:
          Console.WriteLine("Today is Saturday.");
          break;
        case 7:
          Console.WriteLine("Today is Sunday.");
          break;
        default:
          Console.WriteLine("Looking forward to the Weekend.");
          break;
      }    
    }
  }
}