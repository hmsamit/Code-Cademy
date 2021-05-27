using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lets the user enter their password 
            Console.Write("Please enter your desired password: ");
            string password = Console.ReadLine();
            Console.Clear();

            // Lets the user know that the password is already declared
            Console.WriteLine("Password already declared");

            //Checks a password if it has uppercase letters and doesn’t include symbols
            bool ContainsUpperLetter = password.Any(char.IsUpper);
            bool ContainSymbol = password.Any(char.IsSymbol); // need to put using System.Linq; 

            if (ContainsUpperLetter == true)
            {
                Console.WriteLine("Your password is strong!");
            }
            if (ContainSymbol == true)
            {
                Console.WriteLine("Your password is stronger!");
            }
            else
            {
                Console.WriteLine("Sorry! Try another password that is unbreakable");
            }
           



            Console.ReadKey();
        }
    }
}
