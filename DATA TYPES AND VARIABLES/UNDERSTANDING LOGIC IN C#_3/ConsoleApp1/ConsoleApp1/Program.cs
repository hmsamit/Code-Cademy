using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lets the user enter their password 
            Console.Write("Please enter your desired password:");
            string password = Console.ReadLine();
            

            // Lets the user know that the password is already declared
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Password already declared..........\n");


            //Checks a password if it has uppercase letters and doesn’t include symbols
            bool ContainsUpperLetter = password.Any(char.IsUpper);
            bool ContainSymbol = password.Any(char.IsSymbol); // need to put using System.Linq; 
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (ContainsUpperLetter == true)
            {
                Console.WriteLine("\n+-----------------------------+");
                Console.WriteLine("|   Your password is strong!  |");
                Console.WriteLine("+-----------------------------+");
                if (ContainSymbol == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n+-----------------------------+");
                    Console.WriteLine("|   Your password is strong!  |");
                    Console.WriteLine("+-----------------------------+");
                    if (ContainsUpperLetter && ContainSymbol) // nested loop
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n+-----------------------------+");
                        Console.WriteLine("|  Your password is stronger! |");
                        Console.WriteLine("+-----------------------------+");
                    }
                }
                
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sorry, seems like the password you entered is weak.\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please try again.");
            }

            Console.ReadKey();
        }
    }
}
