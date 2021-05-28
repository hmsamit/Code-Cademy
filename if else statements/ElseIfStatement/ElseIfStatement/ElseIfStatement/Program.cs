using System;

namespace ElseIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //You’re having board game night with your friends, but you’re not sure how many people will show up. You want to write a program that prints out what game to play depending on the number of guests:

            //If 4 or more people show up, you’ll play Catan.If 1 to 3 people show up, you’ll play Innovation.If no one shows up, you’ll play Solitaire.

            //First, write the conditional statement for if you have at least 4 friends show up.If the condition is true, have it print out Catan.
            int guests = 3;
            
            if (guests >= 4)
            {
                Console.WriteLine("Catan");
            }
            //Next, modify the statement with another condition that outputs the game Innovation if at least 1 person shows up.
            else if (guests >=1)
            {
                Console.WriteLine("Innovation");
            }
            //Lastly, if no one shows up, have the program print Solitaire to the console.
            else
            {
                Console.WriteLine("Solitaire");
            }
        }
    }
}
