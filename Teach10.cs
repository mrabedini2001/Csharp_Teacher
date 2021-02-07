//  more about string
using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      Console.WriteLine("The length of the txt string is: " + txt.Length);


      string txt = "Hello World";
      Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
      Console.WriteLine(txt.ToLower());   // Outputs "hello world"
    
      
      string firstName = "John ";
      string lastName = "Doe";
      string name = string.Concat(firstName, lastName);
      Console.WriteLine(name);


      string firstName = "John";
      string lastName = "Doe";
      string name = $"My full name is: {firstName} {lastName}";
      Console.WriteLine(name);


      string myString = "Hello";
      Console.WriteLine(myString[0]);  // Outputs "H"
      

      string myString = "Hello";
      Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
      

      

        // Full name
        string name = "John Doe";
        // Location of the letter D
        int charPos = name.IndexOf("D");
        // Get last name
        string lastName = name.Substring(charPos);
        // Print the result
        Console.WriteLine(lastName);




        string txt = "We are the so-called \"Vikings\" from the north.";
        string txt = "It\'s alright.";
        string txt = "The character \\ is called backslash.";
        
        
        /*
        \n	New Line	
        \t	Tab	
        \b	Backspace
        */

    }
  }
}