using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Checks a password if it has uppercase letters and doesn’t include symbols
            Console.Write("Please enter your preffered password for your account: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPlease make it strong and hard to guess\n");
            Console.ForegroundColor = ConsoleColor.White;
            string prefferedPassword = Console.ReadLine();

            bool checkerForUpperCaseLetters = prefferedPassword.Any(char.IsUpper);
            bool checkerForSymbols = prefferedPassword.Any(char.IsSymbol);

            if (checkerForSymbols || checkerForUpperCaseLetters)
            {
                Console.WriteLine("\nYour password is strong");
                
            }
            else if (checkerForUpperCaseLetters && checkerForSymbols) 
            {
                Console.WriteLine("\nYour password is stronger");
            }
            else
            {
                Console.WriteLine("\nYour password is weak");
            }
          
            Console.ReadKey();
        }
    }
}
