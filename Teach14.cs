// while and dowhile in c#
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
      }






        int i = 0;
        do 
        {
        Console.WriteLine(i);
        i++;
        }
        while (i < 5);
    }
  }
}