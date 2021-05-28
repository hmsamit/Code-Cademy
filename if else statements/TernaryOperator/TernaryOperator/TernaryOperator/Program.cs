using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //string color = "blue";
            //string result = (color == "blue") ? "blue" : "NOT blue";
            //Console.WriteLine(result);
            //---------------------
            //You’re growing peppers and wrote a program that lets you know if it’s time to pick them. If a pepper is at least 3.5 inches, it’s time to be picked. If it’s not ready, the program should tell you to “wait a little longer”.

           // Start by creating a string variable named message. Save the comparison statement that checks to see if the pepperLength is 3.5 inches or more.

           // Note: This will throw an error, since we have not completed our statement.

            int pepperLength = 4;
            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer ";

            Console.WriteLine(message);


        }
    }
}
