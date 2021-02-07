// variables
using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            Console.WriteLine(myNum);


            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);


            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y


            // Declare Many Variables
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);


            // note for good programmer
            // Good
            int minutesPerHour = 60;
            // OK, but not so easy to understand what m actually is
            int m = 60;
        }
    }
}