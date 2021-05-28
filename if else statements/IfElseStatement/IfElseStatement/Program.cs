using System;

namespace IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //You’re deciding where to go for lunch. If the line isn’t long at SaladMart (10 people or less) AND the weather is nice, you’ll go there.

           // Write an if statement where if the condition is true, it prints out SaladMart.
            int people = 10;
            string weather = "nice";

            if (people <=10 && weather == "nice")
            {
                Console.WriteLine("SaladMart");
            }
            //However, if the line is long and the weather is bad, you’ll go to Soup N Sandwich. Next, add an else statement that prints out Soup N Sandwich.
            else
            {
                Console.WriteLine("Soup N Sandwich");
            }
            Console.ReadKey();
        }
    }
}
