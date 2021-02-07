//  if and else and elseif in c#
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        int x = 20;
        int y = 18;
        if (x > y) 
        {
        Console.WriteLine("x is greater than y");
        }




        int time = 20;
        if (time < 18) 
        {
        Console.WriteLine("Good day.");
        } 
        else 
        {
        Console.WriteLine("Good evening.");
        }
        // Outputs "Good evening."




        int time = 22;
        if (time < 10) 
        {
        Console.WriteLine("Good morning.");
        } 
        else if (time < 20) 
        {
        Console.WriteLine("Good day.");
        } 
        else 
        {
        Console.WriteLine("Good evening.");
        }
        // Outputs "Good evening."


        //  note part 02
        int time = 20;
        string result = (time < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);
    }
  }
}