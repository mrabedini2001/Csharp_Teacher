//  break and continue in c#
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) 
        {
          break;
        }
        Console.WriteLine(i);
      }



        int i = 0;
        while (i < 10) 
        {
        Console.WriteLine(i);
        i++;
        if (i == 4) 
        {
            break;
        }
        }    




        for (int i = 0; i < 10; i++) 
        {
        if (i == 4) 
        {
            continue;
        }
        Console.WriteLine(i);
        }
    }
  }
}