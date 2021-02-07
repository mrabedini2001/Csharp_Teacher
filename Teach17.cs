//  arrays in c#

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
// int[] myNum = {10, 20, 30, 40};

// Sort a string
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}
 
// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
}



using System;
using System.Linq;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // largest value
      Console.WriteLine(myNumbers.Min());  // smallest value
      Console.WriteLine(myNumbers.Sum());  // sum of myNumbers
    }
  }
}