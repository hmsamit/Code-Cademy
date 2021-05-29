using System;

namespace CaptureOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //The designer of C# is "Anders Hejlsberg". His first name is nice, but we want to print the second name alone.

           // First, find the index of the space(" ") in the string designer and store it in a variable indexOfSpace.

            string designer = "Anders Hejlsberg";
            //   // First, find the index of the space(" ") in the string designer and store it in a variable indexOfSpace.
            int indexOfSpace = designer.IndexOf("");
            //Use Substring() and the variable indexOfSpace to get the second name. Store the returned value in a variable secondName.
            string secondName = designer.Substring(indexOfSpace);
            //Print secondName to the console.
            Console.WriteLine(secondName);
        }
    }
}
